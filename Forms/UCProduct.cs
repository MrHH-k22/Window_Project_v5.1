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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Window_Project_v5._1.Forms
{
    public partial class UCProduct : UserControl
    {
        public EventHandler onSelect = null;
        private ImageDAO imageDAO = new ImageDAO();
        Account account = new Account();

        private Product product;
        public UCProduct()
        {
            InitializeComponent();
            SetClickEventForAllControls(this);
        }

        public UCProduct(Product pd, Account acc)
        {
            InitializeComponent();
            SetClickEventForAllControls(this);
            account = acc;
            this.product = pd;
            lblBuyPrice.Text = pd.OriginalPrice.ToString() + " VND";
            lblSellPrice.Text = pd.SalePrice.ToString() + " VND";
            lblProductName.Text = pd.Name.ToString();

            byte[] imageData = imageDAO.GetImageProductData(pd.Id);

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Attempt to create Image object
                    try
                    {
                        pbProductImage.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }

        }



        private void lblItemPrice_Click(object sender, EventArgs e)
        {

        }

        private void UCProduct_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void UCProduct_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }


        private void ratingProduct_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {
        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void UCProduct_DoubleClick(object sender, EventArgs e)
        {
            FBuyDetail fBuyDetail = new FBuyDetail(product,account);
            fBuyDetail.Show();
        }

        private void SetClickEventForAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += UCProduct_DoubleClick; // Gán sự kiện Click cho control
                // Nếu control là một container (như Panel, GroupBox, UserControl,...)
                // gọi đệ quy để thiết lập sự kiện cho các controls con của nó
                if (control.HasChildren)
                {
                    SetClickEventForAllControls(control);
                }
            }
        }

        private void UCProduct_Click(object sender, EventArgs e)
        {
          
        }
    }
}
