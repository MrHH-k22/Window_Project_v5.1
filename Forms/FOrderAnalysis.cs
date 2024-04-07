using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        public FOrderAnalysis(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void FOrderAnalysis_Load(object sender, EventArgs e)
        {
            acc = accountDAO.Retrieve(acc.Id);

            List<Product> allProducts = productDAO.LoadListWithCondition("",acc.Id);
            List<int> allCustomers = productDAO.LoadCustomers(acc.Id);
            int Displaying = 0;
            int waitForConfirmation = 0;
            int completed = 0;
            int cancelled = 0;
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
                else if (pd.OrderCondition == (int)ordercondition.Cancelled)
                {
                    cancelled++;
                }
                else if (pd.OrderCondition == (int)ordercondition.hidden)
                {
                    hidden++;
                }

            }

            convertByte(pbAvatar, acc.Avatar);
            lblName.Text = acc.Name;
            lblMoney.Text = acc.Money.ToString();
            lblOrdersNo.Text = allProducts.Count.ToString();
            lblCustomersNo.Text = allCustomers.Count.ToString();
            lblDisplayingNo.Text = Displaying.ToString();
            lblWaitForConfirmationNo.Text = waitForConfirmation.ToString();
            lblCompletedNo.Text = completed.ToString();
            lblCancelledNo.Text = cancelled.ToString();
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
    }
}
