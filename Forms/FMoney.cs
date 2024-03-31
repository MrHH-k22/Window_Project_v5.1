using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Project_v5._1.Forms
{
    public partial class FMoney : Form
    {
        private Account acc;
        private AccountDAO accountDAO = new AccountDAO();
        public FMoney()
        {
            InitializeComponent();
        }

        public FMoney(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            double.TryParse(txtMoney.Text, out double money);
            if (txtPassword.Text == "" || txtMoney.Text == "")
            {
                MessageBox.Show("You have to fill all information");
            } 
            else if (money < 0)
            {
                MessageBox.Show("Invalid money");
            } 
            else if (txtPassword.Text != acc.Password)
            {
                MessageBox.Show("Wrong Password");
            } 
            else {
                acc.Money += money;
                accountDAO.update(acc);
                MessageBox.Show("Recharge Sucessfull");
            }
            txtPassword.Text = "";
            txtMoney.Text = "";
            FMoney_Load(sender, e);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            double.TryParse(txtMoney.Text, out double money);
            if (txtPassword.Text == "" || txtMoney.Text == "")
            {
                MessageBox.Show("You have to fill all information");
            }
            else if (money < 0)
            {
                MessageBox.Show("Invalid money");
            }
            else if (txtPassword.Text != acc.Password)
            {
                MessageBox.Show("Wrong Password");
            }
            else if (money > acc.Money)
            {
                MessageBox.Show("You do not have enough money to withdraw");
            }
            else
            {
                acc.Money -= money;
                accountDAO.update(acc);
                MessageBox.Show("Withdraw Sucessfull");
            }
            txtPassword.Text = "";
            txtMoney.Text = "";
            FMoney_Load(sender, e);
        }

        private void FMoney_Load(object sender, EventArgs e)
        {
            lblTotalMoney.Text = acc.Money.ToString("N0") + " VND";
            lblName.Text = acc.Name;
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            txtMoney.Text = "50000";
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            txtMoney.Text = "100000";
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            txtMoney.Text = "200000";
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            txtMoney.Text = "500000";
        }
    }
}
