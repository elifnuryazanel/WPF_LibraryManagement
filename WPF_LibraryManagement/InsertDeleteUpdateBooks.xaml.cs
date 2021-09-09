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
    /// Interaction logic for InsertDeleteUpdateBooks.xaml
    /// </summary>
    public partial class InsertDeleteUpdateBooks : Window
    {
        private string sqlCon;
        public InsertDeleteUpdateBooks()
        {
            InitializeComponent();
            sqlCon = "Data Source=DESKTOP-62GPVIP;Initial Catalog=LibraryDB;Persist Security Info=True;User ID=sa;Password=123";
            string query = "select book_id, book_name, book_page, author, book_detail from Books" ;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlCon);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds, "Books");

            using (sqlDataAdapter)
            {
                DataTable stuTable = ds.Tables["Books"];
                //DGrid.Items.Add(stuTable.Rows[0]["book_name"].ToString());
               // foreach()
                DGrid.ItemsSource = stuTable.AsDataView();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedId = (int)((DataRowView)DGrid.SelectedItem).Row["book_id"];
            string book_name = (string)((DataRowView)DGrid.SelectedItem).Row["book_name"];
            if (MessageBox.Show("Do you want to delete "+ book_name +"?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                string query = "delete from Books where book_id=" + selectedId;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlCon);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds, "Books");
                InsertDeleteUpdateBooks idub = new InsertDeleteUpdateBooks();
                idub.Show();
                this.Close();
            }
            
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            InsertNewBook inb = new InsertNewBook();
            inb.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateBookInfo ubi = new UpdateBookInfo();
            int selectedBookId = (int)((DataRowView)DGrid.SelectedItem).Row["book_id"];
            string book_name = (string)((DataRowView)DGrid.SelectedItem).Row["book_name"];
            int book_page = (int)((DataRowView)DGrid.SelectedItem).Row["book_page"];
            string book_details = (string)((DataRowView)DGrid.SelectedItem).Row["book_detail"];
            string book_author = (string)((DataRowView)DGrid.SelectedItem).Row["author"];

            ubi.BookName_.Text = book_name;
            ubi.Author_.Text = book_author;
            ubi.Page_.Text = book_page.ToString();
            ubi.Details_.Text = book_details;

            ubi.BookID.Text = selectedBookId.ToString();
            ubi.UserID.Content = UserID.Content.ToString();
            ubi.UserAuthorisation.Content = UserAuthorisation.Content.ToString();
            ubi.Show();
            this.Close();
        }
    }
}
