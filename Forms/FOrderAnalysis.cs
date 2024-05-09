using Guna.Charts.WinForms.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Project_v5._1.Forms
{
    public partial class FOrderAnalysis : Form
    {
        private Account acc;
        private ProductDAO productDAO = new ProductDAO();
        private AccountDAO accountDAO = new AccountDAO();

        public FOrderAnalysis()
        {
            InitializeComponent();
            containerMenu.Visible = false;
            gunaChart1.Visible = false;
        }

        public FOrderAnalysis(Account acc)
        {
            InitializeComponent();
            containerMenu.Visible = false;
            gunaChart1.Visible = false;
            this.acc = acc;
            dtBeginday.Value = SqlDateTime.MinValue.Value;
            dtEndday.Value = DateTimePicker.MaximumDateTime;

        }

        private void FOrderAnalysis_Load(object sender, EventArgs e)
        {
            // Load customer
            DataTable dtCustomer = productDAO.LoadRegularCustomer(acc.Id, dtBeginday.Value, dtEndday.Value);
            gvCustomer.DataSource = dtCustomer;
            gvCustomer.ColumnHeadersHeight = 40;
            //acc = accountDAO.Retrieve(acc.Id);
            List<Product> allProducts = productDAO.LoadProductWithinPeriod(acc.Id, dtBeginday.Value, dtEndday.Value);
            int Displaying = 0;
            int waitForConfirmation = 0;
            int completed = 0;
            int hidden = 0;

            foreach (Product pd in allProducts)
            {
                if(pd.OrderCondition == (int)ordercondition.Displaying)
                {
                    Displaying++;
                }
                else if (pd.OrderCondition == (int)ordercondition.WaitforConfirmation)
                {
                    waitForConfirmation++;
                }
                else if (pd.OrderCondition == (int)ordercondition.Completed)
                {
                    completed++;
                }
                else if (pd.OrderCondition == (int)ordercondition.hidden)
                {
                    hidden++;
                }

            }

            convertByte(pbAvatar, acc.Avatar);
            lblName.Text = acc.Name;
            lblMoney.Text = acc.Money.ToString("N0") + " VND";
            lblOrdersNo.Text = allProducts.Count.ToString();
            lblCustomersNo.Text = dtCustomer.Rows.Count.ToString();
            lblDisplayingNo.Text = Displaying.ToString();
            lblWaitForConfirmationNo.Text = waitForConfirmation.ToString();
            lblCompletedNo.Text = completed.ToString();
            lblHiddenNo.Text = hidden.ToString();

            /*
            if (allProducts.Count == 0)
            {
                cpProgress.ValueByTransition = 100;
            }
            else
            {
                cpProgress.ValueByTransition = (int)((float)completed / allProducts.Count);
            }
            */
            //Menu
            lblMenuAccountName.Text = acc.Name;
            ratingMenuAccount.Value = acc.AvgRating;
            convertByte(pbMenuAvatar, acc.Avatar);
            //set center screen
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {

        }

        private void labelMoney_Click(object sender, EventArgs e)
        {

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCart f = new FCart(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnPostProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSellDetail f = new FSellDetail(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (containerMenu.Visible == false)
            {
                containerMenu.Visible = true;
            }
            else
            {
                containerMenu.Visible = false;
            }
        }

        private void btnPurchasesOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FTrackOrder f = new FTrackOrder(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FProductManagement f = new FProductManagement(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSavedProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSaveList f = new FSaveList(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnOrderAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FOrderAnalysis f = new FOrderAnalysis(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FInformation f = new FInformation(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMoney f = new FMoney(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignin f = new FSignin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBuy f = new FBuy(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            this.Hide();
            FVoucher f = new FVoucher(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void dtBeginday_ValueChanged(object sender, EventArgs e)
        {
            if (dtBeginday.Value > dtEndday.Value)
            {
                MessageBox.Show("Begin day should be before end day.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                FOrderAnalysis_Load(sender, e);
            }
        }

        private void dtEndday_ValueChanged(object sender, EventArgs e)
        {
            if (dtBeginday.Value > dtEndday.Value)
            {
                MessageBox.Show("End day should be after begin day.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FOrderAnalysis_Load(sender, e);
            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {

            string YearToFilter = dtBeginday.Value.Year.ToString();
            gvCustomer.Visible = false;
            gunaChart1.Visible = true;
            gunaChart1.Datasets.Clear();
            Chart.Bar(gunaChart1, acc.Id, YearToFilter);
            
        }
    }
}
