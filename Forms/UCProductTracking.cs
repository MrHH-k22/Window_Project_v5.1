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
    public partial class UCProductTracking : UserControl
    {
        public UCProductTracking()
        {
            InitializeComponent();
        }

        private void UCProductTracking_Load(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_MouseEnter(object sender, EventArgs e)
        {
            btnDetail.BackColor = Color.FromArgb(239, 250, 253);
            btnDetail.ForeColor = Color.FromArgb(54, 50, 132);
            btnDetail.FlatAppearance.BorderSize = 1;
        }

        private void btnDetail_MouseLeave(object sender, EventArgs e)
        {
            btnDetail.BackColor = Color.FromArgb(54, 50, 132);
            btnDetail.ForeColor = Color.FromArgb(239, 250, 253);
            btnDetail.FlatAppearance.BorderSize = 0;
        }
    }
}
