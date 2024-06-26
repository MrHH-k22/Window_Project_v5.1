﻿using System;
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
    public partial class UCShipping : UserControl
    {
        Shipping shipping = new Shipping();

        public Shipping Shipping { get => shipping; set => shipping = value; }

        public event EventHandler<EventArgs> SelectedChanged;

        public UCShipping()
        {
            InitializeComponent();
            SetEventForAllControls(this);

        }

        public UCShipping(Shipping ship)
        {
            InitializeComponent();
            SetEventForAllControls(this);
            shipping = ship;
            lblRecipientName.Text = shipping.RecipientName.ToString();
            lblAddress.Text = shipping.Address.ToString();
            lblPhoneNo.Text = shipping.PhoneNo.ToString();
        }

        private void SetEventForAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += UCShipping_Click;
                if (control.HasChildren)
                {
                    SetEventForAllControls(control);
                }
            }

        }

        private void UCShipping_Click(object sender, EventArgs e)
        {
            SelectedChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
