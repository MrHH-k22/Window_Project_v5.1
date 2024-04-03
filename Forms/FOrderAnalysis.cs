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
    public partial class FOrderAnalysis : Form
    {
        private Account acc;
        private ProductDAO productDAO = new ProductDAO();

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
            lblName.Text = acc.Name;
            
            List<Product> allProducts = productDAO.LoadListWithCondition("",acc.Id);
            List<int> allCustomers = productDAO.LoadCustomers(acc.Id);
            int completed = 0;

            foreach (Product pd in allProducts)
            {
                if (pd.BuyerID != -1)
                {
                    completed++;
                }
            }

            convertByte(pbAvatar, acc.Avatar);
            lblName.Text = acc.Name;
            lblOrders.Text = allProducts.Count.ToString();
            lblCustomers.Text = allCustomers.Count.ToString();
            lblIncompleted.Text = (allProducts.Count - completed).ToString();
            lblComplete.Text = completed.ToString();
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
    }
}
