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
    public partial class FHomepage : Form
    {
        private Form activeForm;
        protected Account acc;
        public FHomepage()
        {
            InitializeComponent();
            customizeDesign();
        }
        public FHomepage(Account acc)
        {
            InitializeComponent();
            customizeDesign();
            this.acc = acc;
        }
        

        public void customizeDesign()
        {
            panelSellerSubmenu.Visible = false;
            panelBuyerSubmenu.Visible = false;
        }

        public void hideSubmenu()
        {
            if (panelSellerSubmenu.Visible == true)
            {
                panelSellerSubmenu.Visible = false;
            }
            if (panelBuyerSubmenu.Visible == true)
            {
                panelBuyerSubmenu.Visible = false;
            }
        }

        public void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        public void OpenChildForm(Form childform, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelBody.Controls.Add(childform);
            this.panelBody.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            FInformation fInformation = new FInformation(acc);
            fInformation.Show();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            if (panelSellerSubmenu.Visible == true)
            {
                hideSubmenu();
            }
            else
            {
                showSubmenu(panelSellerSubmenu);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FListSell(acc), sender);
        }

        private void btnOrderAnalysis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FOrderAnalysis(), sender);
        }

        private void btnBuyer_Click(object sender, EventArgs e)
        {
            if (panelBuyerSubmenu.Visible == true)
            {
                hideSubmenu();
            }
            else
            {
                showSubmenu(panelBuyerSubmenu);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FBuy(acc), sender);
        }

        private void btnTrackOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FTrackOrder(acc), sender);
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FProductManagement(), sender);
        }

        private void btnSeller_MouseEnter(object sender, EventArgs e)
        {
            btnSeller.BackColor = Color.FromArgb(255, 193, 0);
        }

        private void btnSeller_MouseLeave(object sender, EventArgs e)
        {
            btnSeller.BackColor = Color.FromArgb(54, 50, 132);
        }

        private void btnSell_MouseEnter(object sender, EventArgs e)
        {
            btnSell.BackColor = Color.FromArgb(255, 193, 0);
        }

        private void btnSell_MouseLeave(object sender, EventArgs e)
        {
            btnSell.BackColor = Color.FromArgb(40, 37, 110);

        }

        private void btnOrderAnalysis_MouseEnter(object sender, EventArgs e)
        {
            btnOrderAnalysis.BackColor = Color.FromArgb(255, 193, 0);

        }

        private void btnOrderAnalysis_MouseLeave(object sender, EventArgs e)
        {
            btnOrderAnalysis.BackColor = Color.FromArgb(40, 37, 110);

        }

        private void btnManagement_MouseEnter(object sender, EventArgs e)
        {
            btnManagement.BackColor = Color.FromArgb(255, 193, 0);

        }

        private void btnManagement_MouseLeave(object sender, EventArgs e)
        {
            btnManagement.BackColor = Color.FromArgb(40, 37, 110);

        }

        private void btnBuyer_MouseEnter(object sender, EventArgs e)
        {
            btnBuyer.BackColor = Color.FromArgb(255, 193, 0);

        }

        private void btnBuyer_MouseLeave(object sender, EventArgs e)
        {
            btnBuyer.BackColor = Color.FromArgb(54, 50, 132);

        }

        private void btnBuy_MouseEnter(object sender, EventArgs e)
        {
            btnBuy.BackColor = Color.FromArgb(255, 193, 0);

        }

        private void btnBuy_MouseLeave(object sender, EventArgs e)
        {
            btnBuy.BackColor = Color.FromArgb(40, 37, 110);

        }

        private void btnTrackOrder_MouseEnter(object sender, EventArgs e)
        {
            btnTrackOrder.BackColor = Color.FromArgb(255, 193, 0);

        }

        private void btnTrackOrder_MouseLeave(object sender, EventArgs e)
        {
            btnTrackOrder.BackColor = Color.FromArgb(40, 37, 110);

        }

        private void btnInformation_MouseEnter(object sender, EventArgs e)
        {
            btnInformation.BackColor = Color.FromArgb(255, 193, 0);

        }

        private void btnInformation_MouseLeave(object sender, EventArgs e)
        {
            btnInformation.BackColor = Color.FromArgb(54, 50, 132);

        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(255, 193, 0);

        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(54, 50, 132);

        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FMoney(), sender);
        }
    }
}
