using Assignment4.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmployeeDAO dao = new EmployeeDAO();
            String ID = txtEmpID.Text;
            String Password = txtPassword.Text;
            if (dao.CheckLogin(ID, Password))
            {
                this.Hide();
                frmMaintainBooks frm = new frmMaintainBooks();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid ID or Password\nPlease Try Again");
            }
        }
    }
}
