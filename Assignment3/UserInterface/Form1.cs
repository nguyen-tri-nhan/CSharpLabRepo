using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductLibrary;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        ProductDB prodata = new ProductDB();
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            GetAll();
        }
        private void GetAll()
        {
            dt = prodata.GetProducts();
            txtProductID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtProductID.DataBindings.Add("Text", dt, "ProductID");
            txtProductName.DataBindings.Add("Text", dt, "ProductName");
            txtQuantity.DataBindings.Add("Text", dt, "Quantity");
            txtUnitPrice.DataBindings.Add("Text", dt, "UnitPrice");
            dgvProductList.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtProductID.Text);
            string Name = txtProductName.Text;
            float Price = float.Parse(txtUnitPrice.Text);
            int Quantity = int.Parse(txtQuantity.Text);
            Product product = new Product
            {
                ProductID = ID,
                ProductName = Name,
                UnitPrice = Price,
                Quantity = Quantity
            };
            bool r = prodata.AddNewProduct(product);
            String s = (r == true ? "Successful" : "Fail");
            MessageBox.Show("Add " + s);
            GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtProductID.Text);
            string Name = txtProductName.Text;
            float Price = float.Parse(txtUnitPrice.Text);
            int Quantity = int.Parse(txtQuantity.Text);
            Product product = new Product
            {
                ProductID = ID,
                ProductName = Name,
                UnitPrice = Price,
                Quantity = Quantity
            };
            bool r = prodata.UpdateProduct(product);
            String s = (r == true ? "Successful" : "Fail");
            MessageBox.Show("Update " + s);
            GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtProductID.Text);
            bool r = prodata.DeleteProduct(ID);
            String s = (r == true ? "Successful" : "Fail");
            MessageBox.Show("Delete " + s);
            GetAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            string filter = "Convert(ProductID, 'System.String') like '%" + txtSearch.Text + "%'";
            dv.RowFilter = filter;
        }
    }
}
