using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABWinform1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        ProductData data = new ProductData();
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                int ProID = int.Parse(txtProductID.Text);
                string ProName = txtProductName.Text;
                float Price = float.Parse(txtUnitPrice.Text);
                int Quantity = int.Parse(txtQuantity.Text);

                Product p = new Product
                {
                    ProductID = ProID,
                    ProductName = ProName,
                    UnitPrice = Price,
                    Quantity = Quantity
                };
                data.AddNew(p);
                // display on gridview
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = data.GetProductList;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int ProID = int.Parse(txtProductID.Text);
                data.Remove(ProID);
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = data.GetProductList;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int Proid = int.Parse(txtProductID.Text);
            Product p = data.Find(Proid);
            if (p == null)
            {
                MessageBox.Show("Product not found.");
            }
            else
            {
                txtProductName.Text = p.ProductName;
                txtQuantity.Text = p.Quantity.ToString();
                txtUnitPrice.Text = p.UnitPrice.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
        }
    }
}
