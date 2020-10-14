using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoBigger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<dynamic> itemsList = new List<dynamic>
            {
                new {Id = 1, ItemName="Cafe" },
                new {Id = 2, ItemName="Milk" },
                new {Id = 3, ItemName="Cake" },
            };
            cboItems.DisplayMember = "ItemName";
            cboItems.ValueMember = "Id";
            cboItems.DataSource = itemsList;
        }

        private void cboItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMsg.Text = string.Empty;
            // get item
            int id = (int)cboItems.SelectedValue;
            lbMsg.Text = "ItemID: " + id + Environment.NewLine;
            // lay full 1 item
            dynamic itemSelected = cboItems.SelectedItem;
            lbMsg.Text += "Item is selected: " + itemSelected.Id + ", " + itemSelected.ItemName;
        }
    }
}
