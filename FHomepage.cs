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

        public FHomepage()
        {
            InitializeComponent();
            customizeDesign();
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
            FInformation fInformation = new FInformation();
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
            OpenChildForm(new Forms.FListSell(), sender);
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
            OpenChildForm(new Forms.FBuy(), sender);
        }

        private void btnTrackOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FTrackOrder(), sender);
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FProductManagement(), sender);
        }
    }
}
