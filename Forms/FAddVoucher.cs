using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuCheckBox.Transitions;

namespace Window_Project_v5._1.Forms
{
    public partial class FAddVoucher : Form
    {
        Account account = new Account();
        VoucherDAO voucherDAO = new VoucherDAO();
        public FAddVoucher()
        {
            InitializeComponent();
        }

        public FAddVoucher(Account acc)
        {
            InitializeComponent();
            account = acc;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Voucher voucher = new Voucher(account.Id,txtVoucherName.Text, StringToDouble(txtVoucherValue.Text),dtBeginday.Value,dtEndDay.Value);
            voucherDAO.add(voucher);
            MessageBox.Show("Operation was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double StringToDouble(string str)
        {
            double decimalResult;
            if (double.TryParse(str, out decimalResult))
            {
                return (double)decimalResult;
            }
            return -1;
        }
    }
}
