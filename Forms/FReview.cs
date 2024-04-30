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
    public partial class FReview : Form
    {
        public FReview()
        {
            InitializeComponent();
        }

        private void FReview_Load(object sender, EventArgs e)
        {
            UCReview uc = new UCReview();
            flowLayoutPanel1.Controls.Add(uc);
        }
    }
}
