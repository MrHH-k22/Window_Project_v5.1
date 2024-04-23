namespace Window_Project_v5._1.Forms
{
    partial class FShipping
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcShipping = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpEdit = new System.Windows.Forms.TabPage();
            this.panelBodyEdit = new Guna.UI2.WinForms.Guna2Panel();
            this.panelControl = new Guna.UI2.WinForms.Guna2Panel();
            this.tpAddAddress = new System.Windows.Forms.TabPage();
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecipientName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.flpAddresses = new System.Windows.Forms.FlowLayoutPanel();
            this.ucShipping1 = new Window_Project_v5._1.Forms.UCShipping();
            this.ucShipping2 = new Window_Project_v5._1.Forms.UCShipping();
            this.ucShipping3 = new Window_Project_v5._1.Forms.UCShipping();
            this.tcShipping.SuspendLayout();
            this.tpEdit.SuspendLayout();
            this.panelBodyEdit.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.tpAddAddress.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.flpAddresses.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcShipping
            // 
            this.tcShipping.Controls.Add(this.tpEdit);
            this.tcShipping.Controls.Add(this.tpAddAddress);
            this.tcShipping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcShipping.ItemSize = new System.Drawing.Size(180, 40);
            this.tcShipping.Location = new System.Drawing.Point(0, 0);
            this.tcShipping.Name = "tcShipping";
            this.tcShipping.SelectedIndex = 0;
            this.tcShipping.Size = new System.Drawing.Size(737, 714);
            this.tcShipping.TabButtonHoverState.BorderColor = System.Drawing.Color.White;
            this.tcShipping.TabButtonHoverState.FillColor = System.Drawing.Color.White;
            this.tcShipping.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcShipping.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.tcShipping.TabButtonHoverState.InnerColor = System.Drawing.Color.White;
            this.tcShipping.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcShipping.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.tcShipping.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcShipping.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.tcShipping.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.tcShipping.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcShipping.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tcShipping.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcShipping.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.tcShipping.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.tcShipping.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcShipping.TabIndex = 0;
            this.tcShipping.TabMenuBackColor = System.Drawing.Color.White;
            this.tcShipping.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpEdit
            // 
            this.tpEdit.BackColor = System.Drawing.Color.White;
            this.tpEdit.Controls.Add(this.panelBodyEdit);
            this.tpEdit.Location = new System.Drawing.Point(4, 44);
            this.tpEdit.Name = "tpEdit";
            this.tpEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpEdit.Size = new System.Drawing.Size(729, 666);
            this.tpEdit.TabIndex = 1;
            this.tpEdit.Text = "Edit address";
            // 
            // panelBodyEdit
            // 
            this.panelBodyEdit.Controls.Add(this.flpAddresses);
            this.panelBodyEdit.Controls.Add(this.panelControl);
            this.panelBodyEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBodyEdit.Location = new System.Drawing.Point(3, 3);
            this.panelBodyEdit.Name = "panelBodyEdit";
            this.panelBodyEdit.Padding = new System.Windows.Forms.Padding(4);
            this.panelBodyEdit.Size = new System.Drawing.Size(723, 660);
            this.panelBodyEdit.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.guna2Button1);
            this.panelControl.Controls.Add(this.guna2Button2);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(4, 577);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(715, 79);
            this.panelControl.TabIndex = 0;
            // 
            // tpAddAddress
            // 
            this.tpAddAddress.BackColor = System.Drawing.Color.White;
            this.tpAddAddress.Controls.Add(this.panelBody);
            this.tpAddAddress.Location = new System.Drawing.Point(4, 44);
            this.tpAddAddress.Name = "tpAddAddress";
            this.tpAddAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddAddress.Size = new System.Drawing.Size(702, 666);
            this.tpAddAddress.TabIndex = 0;
            this.tpAddAddress.Text = "Add new address";
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.btnCancel);
            this.panelBody.Controls.Add(this.btnAdd);
            this.panelBody.Controls.Add(this.label2);
            this.panelBody.Controls.Add(this.txtAddress);
            this.panelBody.Controls.Add(this.label1);
            this.panelBody.Controls.Add(this.txtPhoneNo);
            this.panelBody.Controls.Add(this.label3);
            this.panelBody.Controls.Add(this.txtRecipientName);
            this.panelBody.Controls.Add(this.label);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(3, 3);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(696, 660);
            this.panelBody.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.BorderRadius = 23;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(58, 581);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(262, 49);
            this.btnCancel.TabIndex = 133;
            this.btnCancel.Text = "Cancel";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnAdd.BorderRadius = 23;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnAdd.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnAdd.Location = new System.Drawing.Point(370, 581);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(262, 49);
            this.btnAdd.TabIndex = 132;
            this.btnAdd.Text = "Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(13, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 111;
            this.label2.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoScroll = true;
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtAddress.Location = new System.Drawing.Point(18, 300);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAddress.PlaceholderText = "Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(640, 43);
            this.txtAddress.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(13, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 109;
            this.label1.Text = "Phone number";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.AutoScroll = true;
            this.txtPhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.txtPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNo.DefaultText = "";
            this.txtPhoneNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtPhoneNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneNo.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtPhoneNo.Location = new System.Drawing.Point(18, 196);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.PasswordChar = '\0';
            this.txtPhoneNo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPhoneNo.PlaceholderText = "Phone number";
            this.txtPhoneNo.SelectedText = "";
            this.txtPhoneNo.Size = new System.Drawing.Size(640, 43);
            this.txtPhoneNo.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 107;
            this.label3.Text = "Recipient name";
            // 
            // txtRecipientName
            // 
            this.txtRecipientName.AutoScroll = true;
            this.txtRecipientName.BackColor = System.Drawing.Color.Transparent;
            this.txtRecipientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecipientName.DefaultText = "";
            this.txtRecipientName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRecipientName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRecipientName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecipientName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecipientName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtRecipientName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRecipientName.ForeColor = System.Drawing.Color.Black;
            this.txtRecipientName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtRecipientName.Location = new System.Drawing.Point(18, 92);
            this.txtRecipientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRecipientName.Name = "txtRecipientName";
            this.txtRecipientName.PasswordChar = '\0';
            this.txtRecipientName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRecipientName.PlaceholderText = "Recipient name";
            this.txtRecipientName.SelectedText = "";
            this.txtRecipientName.Size = new System.Drawing.Size(640, 43);
            this.txtRecipientName.TabIndex = 105;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(396, 31);
            this.label.TabIndex = 11;
            this.label.Text = "Add new Shipping information";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.Red;
            this.guna2Button1.BorderRadius = 23;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.Location = new System.Drawing.Point(35, 15);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(262, 49);
            this.guna2Button1.TabIndex = 135;
            this.guna2Button1.Text = "Cancel";
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.guna2Button2.BorderRadius = 23;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button2.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.guna2Button2.Location = new System.Drawing.Point(347, 15);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(262, 49);
            this.guna2Button2.TabIndex = 134;
            this.guna2Button2.Text = "Save";
            // 
            // flpAddresses
            // 
            this.flpAddresses.AutoScroll = true;
            this.flpAddresses.Controls.Add(this.ucShipping1);
            this.flpAddresses.Controls.Add(this.ucShipping2);
            this.flpAddresses.Controls.Add(this.ucShipping3);
            this.flpAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAddresses.Location = new System.Drawing.Point(4, 4);
            this.flpAddresses.Name = "flpAddresses";
            this.flpAddresses.Size = new System.Drawing.Size(715, 573);
            this.flpAddresses.TabIndex = 1;
            // 
            // ucShipping1
            // 
            this.ucShipping1.BackColor = System.Drawing.Color.White;
            this.ucShipping1.Location = new System.Drawing.Point(3, 3);
            this.ucShipping1.Name = "ucShipping1";
            this.ucShipping1.Size = new System.Drawing.Size(680, 218);
            this.ucShipping1.TabIndex = 0;
            // 
            // ucShipping2
            // 
            this.ucShipping2.BackColor = System.Drawing.Color.White;
            this.ucShipping2.Location = new System.Drawing.Point(3, 227);
            this.ucShipping2.Name = "ucShipping2";
            this.ucShipping2.Size = new System.Drawing.Size(680, 218);
            this.ucShipping2.TabIndex = 1;
            // 
            // ucShipping3
            // 
            this.ucShipping3.BackColor = System.Drawing.Color.White;
            this.ucShipping3.Location = new System.Drawing.Point(3, 451);
            this.ucShipping3.Name = "ucShipping3";
            this.ucShipping3.Size = new System.Drawing.Size(680, 218);
            this.ucShipping3.TabIndex = 2;
            // 
            // FShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 714);
            this.Controls.Add(this.tcShipping);
            this.Name = "FShipping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FShipping";
            this.tcShipping.ResumeLayout(false);
            this.tpEdit.ResumeLayout(false);
            this.panelBodyEdit.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.tpAddAddress.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.flpAddresses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcShipping;
        private System.Windows.Forms.TabPage tpEdit;
        private Guna.UI2.WinForms.Guna2Panel panelBodyEdit;
        private System.Windows.Forms.TabPage tpAddAddress;
        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        public System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        public System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNo;
        public System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtRecipientName;
        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2Panel panelControl;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.FlowLayoutPanel flpAddresses;
        private UCShipping ucShipping1;
        private UCShipping ucShipping2;
        private UCShipping ucShipping3;
    }
}