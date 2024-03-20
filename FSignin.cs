using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Project_v5._1.Forms
{
    public partial class FSignin : Form
    {
        AccountDAO accountDAO = new AccountDAO();
        public FSignin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            if(string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email has not been filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password has not been filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Account acc = new Account(email, password);
                acc = accountDAO.CheckAccount(acc);
                if(acc == null)
                {
                    MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    FHomepage fHomepage = new FHomepage(acc);
                    fHomepage.Show();
                }
            }

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            FSignup fSignup = new FSignup();
            fSignup.Show();
        }
    }
}
