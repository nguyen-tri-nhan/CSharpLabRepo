using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void password_Validating(object sender, CancelEventArgs e)
        {
            if (password.Text.Length > 5)
            {
                this.errorProvider1.SetError(password, "Cant be greater than 5!");
            }
            else this.errorProvider1.SetError(password, "");
        }
    }
}
