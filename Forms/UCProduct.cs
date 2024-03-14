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
    public partial class UCProduct : UserControl
    {
        public EventHandler onSelect = null;
        public UCProduct()
        {
            InitializeComponent();
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

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FBuyDetail fBuyDetail = new FBuyDetail();
            fBuyDetail.Show();
        }

        private void ratingProduct_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {
        }
    }
}
