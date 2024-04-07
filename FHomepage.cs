using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Project_v5._1.Forms
{
    public partial class FHomepage : Form
    {
        private Form activeForm;
        private AccountDAO accountDAO = new AccountDAO();
        protected Account acc;
        public FHomepage()
        {
            InitializeComponent();
        }
        public FHomepage(Account acc)
        {
            InitializeComponent();
            this.acc = accountDAO.Retrieve(acc.Id);
        }
        
        /*
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
        */

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
            this.containerBody.Controls.Add(childform);
            this.containerBody.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        /*

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FProductManagement(acc), sender);
        }

        private void btnSavedProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FSaveList(acc), sender);
        }

        private void btnOrderAnalysis_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FOrderAnalysis(acc), sender);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FInformation(acc), sender);
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FInformation(acc), sender);
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        */

        private void FHomepage_Load(object sender, EventArgs e)
        {
            containerMenu.SendToBack();
            lblAccountName.Text = acc.Name;
            convertByte(pbAvatar, acc.Avatar);
            OpenChildForm(new Forms.FBuy(acc), sender);
        }

        private bool IsControlAtFront(Control control)
        {
            while (control.Parent != null)
            {
                if (control.Parent.Controls.GetChildIndex(control) == 0)
                {
                    control = control.Parent;
                    if (control.Parent == null)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(IsControlAtFront(containerMenu))
            {
                containerMenu.SendToBack();
            }
            else
            {
                containerMenu.BringToFront();
            }
        }



        private void btnPurchasesOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FTrackOrder(acc), sender);
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FProductManagement(acc), sender);
        }

        private void btnSavedProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FSaveList(acc), sender);
        }

        private void btnOrderAnalysis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FOrderAnalysis(acc), sender);
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FInformation(acc), sender);
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FInformation(acc), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignin f = new FSignin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnPostProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FSellDetail(acc), sender);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FCart(acc), sender);
        }

        private void convertByte(PictureBox pic, byte[] imageData)
        {

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Attempt to create Image object
                    try
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }
        }
    }
}
