using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window_Project_v5._1.Forms;
using Window_Project_v5._1.Properties;

namespace Window_Project_v5._1.MessageForms
{
    public partial class FMessageSuccess : Form
    {
        public FMessageSuccess()
        {
            InitializeComponent();
            ucMessageBox1.pbIcon.Image = Resources.MessageSuccess;
            ucMessageBox1.btnYes.Click += BtnYes_Click;
            ucMessageBox1.btnNo.Click += BtnNo_Click;
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            
        }

        public void ChangeInforMessageSuccess(string caption, string content, string namebtn1, string namebtn2)
        {
            ucMessageBox1.lblCaption.Text = caption;
            ucMessageBox1.lblContent.Text = content;
            ucMessageBox1.btnYes.Text = namebtn1;
            ucMessageBox1.btnNo.Text = namebtn2;
        }
        
        
       
    }
}
