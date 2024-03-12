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
        public FHomepage()
        {
            InitializeComponent();
            customizeDesign();
        }

        public void customizeDesign()
        {
            panelBuyerSubmenu.Visible = false;
            panelSellerSubmenu.Visible = false;
        }

        public void hideSubmenu()
        {
            if (panelBuyerSubmenu.Visible == true)
            {
                panelBuyerSubmenu.Visible = false;
            }
            if (panelSellerSubmenu.Visible == true)
            {
                panelSellerSubmenu.Visible = false;
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
