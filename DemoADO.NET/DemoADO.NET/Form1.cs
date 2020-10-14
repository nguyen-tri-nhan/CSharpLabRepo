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

namespace DemoADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dvgBookList.ReadOnly = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }
        String ConnectionString = @"server=DESKTOP-LVLR7JR;database=demoBookStore;uid=sa;pwd=123456789";
        SqlDataAdapter adapter;
        DataTable BookTable;
        public void LoadBooks()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            String SQL = "SELECT BookID, BookName FROM tblBooks";
            SqlCommand command = new SqlCommand(SQL, conn);
            adapter = new SqlDataAdapter(command);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            BookTable = new DataTable();
            adapter.Fill(BookTable);
            dvgBookList.DataSource = BookTable;
            txtBookID.DataBindings.Clear();
            txtBookName.DataBindings.Clear();
            txtBookID.DataBindings.Add("Text", BookTable, "BookID");
            txtBookName.DataBindings.Add("Text", BookTable, "BookName");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string SQL = "INSERT tblBooks VALUES(@id,@name)";
            SqlCommand command = new SqlCommand(SQL, conn);
            command.Parameters.AddWithValue("id", txtBookID.Text);
            command.Parameters.AddWithValue("name", txtBookName.Text);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            LoadBooks();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string SQL = "UPDATE tblBooks SET BookName = @name" +
                " WHERE BookId = @id";
            SqlCommand command = new SqlCommand(SQL, conn);
            command.Parameters.AddWithValue("id", txtBookID.Text);
            command.Parameters.AddWithValue("name", txtBookName.Text);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            LoadBooks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string SQL = "DELETE tblBooks WHERE BookId = @id";
            SqlCommand command = new SqlCommand(SQL, conn);
            command.Parameters.AddWithValue("id", txtBookID.Text);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            LoadBooks();
        }
    }
}
