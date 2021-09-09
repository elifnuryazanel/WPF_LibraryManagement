using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WPF_LibraryManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string sqlCon;
        public MainWindow()
        {
            InitializeComponent();
            sqlCon = "Data Source=LAPTOP-8MJAND76;Initial Catalog=LibraryDB;Persist Security Info=True;User ID=sa;Password=elifnur";
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string query = "select Kullanici_id,Kullanici_yetki from kullanici where kullanici_adi='"+ user_name.Text.ToString() + "' and Kullanici_sifre='"+txtPassword.Password.ToString() + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlCon);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds,"Kullanici");

            using (sqlDataAdapter)
            {
                DataTable stuTable = ds.Tables["Kullanici"];
                if(stuTable.Rows.Count == 1)
                {
                    UserMainPage user_page = new UserMainPage();
                    if(stuTable.Rows[0]["Kullanici_yetki"].ToString() == "True")
                        user_page.InsertNewBook.Visibility = Visibility.Visible;
                    user_page.Show();
                    user_page.UserID.Content = stuTable.Rows[0]["Kullanici_id"].ToString();
                    user_page.UserAuthorisation.Text = stuTable.Rows[0]["Kullanici_yetki"].ToString();
                    this.Close();
                }
            }
        }
    }
}
