using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window_Project_v5._1.Forms;
using Window_Project_v5._1.Properties;

namespace Window_Project_v5._1.MessageForms
{
    public partial class FMessageInfo : Form
    {
        public FMessageInfo()
        {
            InitializeComponent();
            ucMessageBox1.pbIcon.Image = Resources.MessageInfo;
            ucMessageBox1.btnYes.Click += BtnYes_Click;
            ucMessageBox1.btnNo.Click += BtnNo_Click;
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
