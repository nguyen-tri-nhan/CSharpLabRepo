using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinForm
{
    public partial class formOrders : Form
    {
        public formOrders()
        {
            InitializeComponent();
        }

        private void formOrders_Load(object sender, EventArgs e)
        {
            tsCurrDate.Text = DateTime.Now.ToString();
            this.IsMdiContainer = true;
        }


        private void exitToolStripMenuItem_click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.close
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMain frm = new formMain();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
