using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window_Project_v5._1.Properties;

namespace Window_Project_v5._1.Forms
{
    public partial class FProductDetail : Form
    {
        public FProductDetail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFavorite_MouseEnter(object sender, EventArgs e)
        {
            btnFavorite.BackgroundImage = Resources.heart_v2_pink;
        }

        private void btnFavorite_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnFavorite_MouseLeave(object sender, EventArgs e)
        {
            btnFavorite.BackgroundImage = Resources.heart_v2;
        }
    }
}
