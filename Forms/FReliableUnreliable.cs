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
    public partial class FReliableUnreliable : Form
    {
        RatingDAO ratingDAO = new RatingDAO();
        DataTable reliableseller = new DataTable();
        DataTable unreliableseller = new DataTable();
        string state = "";
        //public FReliableUnreliable() { }
        public FReliableUnreliable()
        {
            InitializeComponent();
            reliableseller = ratingDAO.GetTableRating("desc");
            unreliableseller = ratingDAO.GetTableRating("asc");
            
            
        }

        private void FReliableUnreliable_Load(object sender, EventArgs e)
        {
            if(state == "desc")
            {
                gvInfor.DataSource = reliableseller;
            }
            if(state == "asc")
            {
                gvInfor.DataSource = unreliableseller;
            }
        }

        private void btnDESC_Click(object sender, EventArgs e)
        {
            state = "desc";
            FReliableUnreliable_Load(sender, e);
        }

        private void btnASC_Click(object sender, EventArgs e)
        {
            state = "asc";
            FReliableUnreliable_Load(sender, e);
        }
    }
}
