
namespace SchedulingService.Views
{
	partial class CustomerForm
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
            this.customerFormLabel = new System.Windows.Forms.Label();
            this.addressGroupBox = new System.Windows.Forms.GroupBox();
            this.postalCode = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.city = new System.Windows.Forms.ComboBox();
            this.addressLine2 = new System.Windows.Forms.TextBox();
            this.addressLine1 = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLine2Label = new System.Windows.Forms.Label();
            this.addressLine1Label = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.activeCustomer = new System.Windows.Forms.RadioButton();
            this.inactiveCustomer = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addressGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerFormLabel
            // 
            this.customerFormLabel.AutoSize = true;
            this.customerFormLabel.Location = new System.Drawing.Point(16, 11);
            this.customerFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerFormLabel.Name = "customerFormLabel";
            this.customerFormLabel.Size = new System.Drawing.Size(142, 17);
            this.customerFormLabel.TabIndex = 0;
            this.customerFormLabel.Text = "Add/Modify Customer";
            // 
            // addressGroupBox
            // 
            this.addressGroupBox.Controls.Add(this.postalCode);
            this.addressGroupBox.Controls.Add(this.phoneNumber);
            this.addressGroupBox.Controls.Add(this.city);
            this.addressGroupBox.Controls.Add(this.addressLine2);
            this.addressGroupBox.Controls.Add(this.addressLine1);
            this.addressGroupBox.Controls.Add(this.phoneNumberLabel);
            this.addressGroupBox.Controls.Add(this.postalCodeLabel);
            this.addressGroupBox.Controls.Add(this.cityLabel);
            this.addressGroupBox.Controls.Add(this.addressLine2Label);
            this.addressGroupBox.Controls.Add(this.addressLine1Label);
            this.addressGroupBox.Location = new System.Drawing.Point(247, 182);
            this.addressGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressGroupBox.Name = "addressGroupBox";
            this.addressGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.addressGroupBox.Size = new System.Drawing.Size(581, 265);
            this.addressGroupBox.TabIndex = 8;
            this.addressGroupBox.TabStop = false;
            this.addressGroupBox.Text = "Address";
            // 
            // postalCode
            // 
            this.postalCode.Location = new System.Drawing.Point(416, 141);
            this.postalCode.Mask = "00000";
            this.postalCode.Name = "postalCode";
            this.postalCode.Size = new System.Drawing.Size(156, 22);
            this.postalCode.TabIndex = 7;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(181, 191);
            this.phoneNumber.Mask = "000-0000";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(156, 22);
            this.phoneNumber.TabIndex = 8;
            // 
            // city
            // 
            this.city.FormattingEnabled = true;
            this.city.Location = new System.Drawing.Point(65, 139);
            this.city.Margin = new System.Windows.Forms.Padding(4);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(160, 24);
            this.city.TabIndex = 6;
            // 
            // addressLine2
            // 
            this.addressLine2.Location = new System.Drawing.Point(181, 87);
            this.addressLine2.Margin = new System.Windows.Forms.Padding(4);
            this.addressLine2.Name = "addressLine2";
            this.addressLine2.Size = new System.Drawing.Size(391, 22);
            this.addressLine2.TabIndex = 5;
            // 
            // addressLine1
            // 
            this.addressLine1.Location = new System.Drawing.Point(181, 34);
            this.addressLine1.Margin = new System.Windows.Forms.Padding(4);
            this.addressLine1.Name = "addressLine1";
            this.addressLine1.Size = new System.Drawing.Size(391, 22);
            this.addressLine1.TabIndex = 4;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(8, 194);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.phoneNumberLabel.TabIndex = 12;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Location = new System.Drawing.Point(299, 143);
            this.postalCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(84, 17);
            this.postalCodeLabel.TabIndex = 11;
            this.postalCodeLabel.Text = "Postal Code";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(8, 143);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 17);
            this.cityLabel.TabIndex = 10;
            this.cityLabel.Text = "City";
            // 
            // addressLine2Label
            // 
            this.addressLine2Label.AutoSize = true;
            this.addressLine2Label.Location = new System.Drawing.Point(8, 91);
            this.addressLine2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLine2Label.Name = "addressLine2Label";
            this.addressLine2Label.Size = new System.Drawing.Size(103, 17);
            this.addressLine2Label.TabIndex = 9;
            this.addressLine2Label.Text = "Address Line 2";
            // 
            // addressLine1Label
            // 
            this.addressLine1Label.AutoSize = true;
            this.addressLine1Label.Location = new System.Drawing.Point(8, 38);
            this.addressLine1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLine1Label.Name = "addressLine1Label";
            this.addressLine1Label.Size = new System.Drawing.Size(103, 17);
            this.addressLine1Label.TabIndex = 8;
            this.addressLine1Label.Text = "Address Line 1";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(255, 91);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(109, 17);
            this.customerNameLabel.TabIndex = 6;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(428, 87);
            this.customerName.Margin = new System.Windows.Forms.Padding(4);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(391, 22);
            this.customerName.TabIndex = 1;
            // 
            // activeCustomer
            // 
            this.activeCustomer.AutoSize = true;
            this.activeCustomer.Location = new System.Drawing.Point(364, 137);
            this.activeCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.activeCustomer.Name = "activeCustomer";
            this.activeCustomer.Size = new System.Drawing.Size(131, 21);
            this.activeCustomer.TabIndex = 2;
            this.activeCustomer.TabStop = true;
            this.activeCustomer.Text = "Active Customer";
            this.activeCustomer.UseVisualStyleBackColor = true;
            // 
            // inactiveCustomer
            // 
            this.inactiveCustomer.AutoSize = true;
            this.inactiveCustomer.Location = new System.Drawing.Point(583, 137);
            this.inactiveCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.inactiveCustomer.Name = "inactiveCustomer";
            this.inactiveCustomer.Size = new System.Drawing.Size(141, 21);
            this.inactiveCustomer.TabIndex = 3;
            this.inactiveCustomer.TabStop = true;
            this.inactiveCustomer.Text = "Inactive Customer";
            this.inactiveCustomer.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(312, 473);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(183, 33);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.inactiveCustomer);
            this.Controls.Add(this.activeCustomer);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.addressGroupBox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerFormLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.addressGroupBox.ResumeLayout(false);
            this.addressGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label customerFormLabel;
        private System.Windows.Forms.GroupBox addressGroupBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressLine2Label;
        private System.Windows.Forms.Label addressLine1Label;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.TextBox addressLine2;
        private System.Windows.Forms.TextBox addressLine1;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.RadioButton activeCustomer;
        private System.Windows.Forms.RadioButton inactiveCustomer;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox phoneNumber;
        private System.Windows.Forms.MaskedTextBox postalCode;
    }
}