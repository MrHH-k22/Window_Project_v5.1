﻿using System;
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
    public partial class FSignup : Form
    {
        AccountDAO accountDAO = new AccountDAO();
        public FSignup()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            FSignin fSignin = new FSignin();
            fSignin.Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Account acc = new Account(txtUsername.Text, txtEmail.Text ,txtPassword.Text);
            accountDAO.CreateNewAccount(acc);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
