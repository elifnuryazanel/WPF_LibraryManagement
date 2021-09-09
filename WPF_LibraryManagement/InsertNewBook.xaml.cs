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
using System.Windows.Shapes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WPF_LibraryManagement
{
    /// <summary>
    /// Interaction logic for InsertNewBook.xaml
    /// </summary>
    public partial class InsertNewBook : Window
    {
        public InsertNewBook()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            string sqlCon = "Data Source=DESKTOP-62GPVIP;Initial Catalog=LibraryDB;Persist Security Info=True;User ID=sa;Password=123";
            string query = "insert into books (book_name, book_page, author, book_detail) values('" + BookName_.Text + "', " + Convert.ToInt32(Page_.Text) + ", '" + Author_.Text + "', '" + Details_.Text + "')";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlCon);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            MessageBox.Show("The item is saved!");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            InsertDeleteUpdateBooks idub = new InsertDeleteUpdateBooks();
            idub.Show();
            this.Close();
        }
    }
}
