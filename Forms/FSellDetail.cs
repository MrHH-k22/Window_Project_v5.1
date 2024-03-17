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
    public partial class FSellDetail : Form
    {
        public FSellDetail()
        {
            InitializeComponent();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImage1_Click(object sender, EventArgs e)
        {
            btnImage1.Image = Resources.MessageSuccess;
        }
    }
}
