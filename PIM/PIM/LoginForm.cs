using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "admin" && txtPWD.Text == "1234")
            {
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
                this.Hide();
            }
            else if (txtID.Text == "admin" && txtPWD.Text != "1234")
            {
                MessageBox.Show("Password를 다시 확인하십시오");
                txtPWD.Text = "";
            }
            else if (txtID.Text != "admin" && txtPWD.Text == "1234")
            {
                MessageBox.Show("ID를 다시 확인하십시오");
                txtID.Text = "";
            }
            else
            {
                MessageBox.Show("ID, Password 모두 다시 확인하십시오");
                txtID.Text = "";
                txtPWD.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk_Click(sender, e);
            }
        }
    }
}
