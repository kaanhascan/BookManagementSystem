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
    public partial class ListingForm : Form
    {
        public ListingForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=KAAN-MATEBOOK;Initial Catalog=borrowedbooks;Integrated Security=True");
        DataSet bm = new DataSet();
        BorrowBook borrowform = new BorrowBook();


        private void LoadData(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            viewgrid.DataSource = table;
        }


        private void listbooksbutton_Click(object sender, EventArgs e)
        {
            LoadData("select * from books");
        }

        private void listmembersbutton_Click(object sender, EventArgs e)
        {
            LoadData("select * from members");
        }

        private void listalreadyborrowedbutton_Click(object sender, EventArgs e)
        {
            LoadData("select * from borrowed");
        }

        private void borrowbookbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            borrowform.Show();
        }
    }
    
}
