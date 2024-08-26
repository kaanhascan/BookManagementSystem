using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookManagementSystem
{
    public partial class BorrowBook : Form
    {
        public BorrowBook()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=KAAN-MATEBOOK;Initial Catalog=borrowedbooks;Integrated Security=True");
        //ListingForm lform = new ListingForm();


        private void LoadData(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            availableview.DataSource = dt;
        }

        private void showavailablebooksbutton_Click(object sender, EventArgs e)
        {
            LoadData("Select * from books where BookBorrowed = 'N'");
        }

        private void borrowbutton_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();


                SqlCommand checkBookStatus = new SqlCommand("SELECT BookBorrowed FROM books WHERE BookID = @bid", connection);
                checkBookStatus.Parameters.AddWithValue("@bid", bookidtext.Text);


                string status = (string)checkBookStatus.ExecuteScalar();

                if (status == "Y")
                {
                    MessageBox.Show("This book is already borrowed. You cannot borrow it until it returns.");
                }
                else
                {

                    SqlCommand borrow = new SqlCommand("INSERT INTO borrowed (BookID, MemberID, BorrowDate, ReturnDate) VALUES (@bid, @mid, @bdate, @rdate)", connection);
                    borrow.Parameters.AddWithValue("@bid", bookidtext.Text);
                    borrow.Parameters.AddWithValue("@mid", memberidtext.Text);
                    borrow.Parameters.AddWithValue("@bdate", DateTime.Now);
                    borrow.Parameters.AddWithValue("@rdate", DateTime.Now.AddDays(120));

                    borrow.ExecuteNonQuery();


                    SqlCommand updateBookStatus = new SqlCommand("UPDATE books SET BookBorrowed = 'Y' WHERE BookID = @bid", connection);
                    updateBookStatus.Parameters.AddWithValue("@bid", bookidtext.Text);
                    updateBookStatus.ExecuteNonQuery();

                    MessageBox.Show("You successfully made your registration. " +
                                    $"You need to return the book by {DateTime.Now.AddDays(120):yyyy-MM-dd} or you will be fined. " +
                                    "Thanks for your concern.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {

                connection.Close();
            }
        }
    }
}
