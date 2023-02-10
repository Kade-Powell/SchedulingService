
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
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.addressLine1Label = new System.Windows.Forms.Label();
            this.addressLine2Label = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.addressLine1 = new System.Windows.Forms.TextBox();
            this.addressLine2 = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.ComboBox();
            this.postalCode = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.activeCustomer = new System.Windows.Forms.RadioButton();
            this.inactiveCustomer = new System.Windows.Forms.RadioButton();
            this.addressGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerFormLabel
            // 
            this.customerFormLabel.AutoSize = true;
            this.customerFormLabel.Location = new System.Drawing.Point(12, 9);
            this.customerFormLabel.Name = "customerFormLabel";
            this.customerFormLabel.Size = new System.Drawing.Size(109, 13);
            this.customerFormLabel.TabIndex = 0;
            this.customerFormLabel.Text = "Add/Modify Customer";
            // 
            // addressGroupBox
            // 
            this.addressGroupBox.Controls.Add(this.phoneNumber);
            this.addressGroupBox.Controls.Add(this.postalCode);
            this.addressGroupBox.Controls.Add(this.city);
            this.addressGroupBox.Controls.Add(this.addressLine2);
            this.addressGroupBox.Controls.Add(this.addressLine1);
            this.addressGroupBox.Controls.Add(this.phoneNumberLabel);
            this.addressGroupBox.Controls.Add(this.postalCodeLabel);
            this.addressGroupBox.Controls.Add(this.cityLabel);
            this.addressGroupBox.Controls.Add(this.addressLine2Label);
            this.addressGroupBox.Controls.Add(this.addressLine1Label);
            this.addressGroupBox.Location = new System.Drawing.Point(185, 148);
            this.addressGroupBox.Name = "addressGroupBox";
            this.addressGroupBox.Size = new System.Drawing.Size(436, 215);
            this.addressGroupBox.TabIndex = 8;
            this.addressGroupBox.TabStop = false;
            this.addressGroupBox.Text = "Address";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(191, 74);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 6;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // addressLine1Label
            // 
            this.addressLine1Label.AutoSize = true;
            this.addressLine1Label.Location = new System.Drawing.Point(6, 31);
            this.addressLine1Label.Name = "addressLine1Label";
            this.addressLine1Label.Size = new System.Drawing.Size(77, 13);
            this.addressLine1Label.TabIndex = 8;
            this.addressLine1Label.Text = "Address Line 1";
            // 
            // addressLine2Label
            // 
            this.addressLine2Label.AutoSize = true;
            this.addressLine2Label.Location = new System.Drawing.Point(6, 74);
            this.addressLine2Label.Name = "addressLine2Label";
            this.addressLine2Label.Size = new System.Drawing.Size(77, 13);
            this.addressLine2Label.TabIndex = 9;
            this.addressLine2Label.Text = "Address Line 2";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(6, 116);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 10;
            this.cityLabel.Text = "City";
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Location = new System.Drawing.Point(224, 116);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.postalCodeLabel.TabIndex = 11;
            this.postalCodeLabel.Text = "Postal Code";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(6, 158);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLabel.TabIndex = 12;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(321, 71);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(294, 20);
            this.customerName.TabIndex = 9;
            // 
            // addressLine1
            // 
            this.addressLine1.Location = new System.Drawing.Point(136, 28);
            this.addressLine1.Name = "addressLine1";
            this.addressLine1.Size = new System.Drawing.Size(294, 20);
            this.addressLine1.TabIndex = 10;
            // 
            // addressLine2
            // 
            this.addressLine2.Location = new System.Drawing.Point(136, 71);
            this.addressLine2.Name = "addressLine2";
            this.addressLine2.Size = new System.Drawing.Size(294, 20);
            this.addressLine2.TabIndex = 13;
            // 
            // city
            // 
            this.city.FormattingEnabled = true;
            this.city.Location = new System.Drawing.Point(49, 113);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(121, 21);
            this.city.TabIndex = 14;
            // 
            // postalCode
            // 
            this.postalCode.Location = new System.Drawing.Point(311, 113);
            this.postalCode.Name = "postalCode";
            this.postalCode.Size = new System.Drawing.Size(119, 20);
            this.postalCode.TabIndex = 15;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(136, 158);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(119, 20);
            this.phoneNumber.TabIndex = 16;
            // 
            // activeCustomer
            // 
            this.activeCustomer.AutoSize = true;
            this.activeCustomer.Location = new System.Drawing.Point(273, 111);
            this.activeCustomer.Name = "activeCustomer";
            this.activeCustomer.Size = new System.Drawing.Size(102, 17);
            this.activeCustomer.TabIndex = 10;
            this.activeCustomer.TabStop = true;
            this.activeCustomer.Text = "Active Customer";
            this.activeCustomer.UseVisualStyleBackColor = true;
            // 
            // inactiveCustomer
            // 
            this.inactiveCustomer.AutoSize = true;
            this.inactiveCustomer.Location = new System.Drawing.Point(437, 111);
            this.inactiveCustomer.Name = "inactiveCustomer";
            this.inactiveCustomer.Size = new System.Drawing.Size(110, 17);
            this.inactiveCustomer.TabIndex = 11;
            this.inactiveCustomer.TabStop = true;
            this.inactiveCustomer.Text = "Inactive Customer";
            this.inactiveCustomer.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inactiveCustomer);
            this.Controls.Add(this.activeCustomer);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.addressGroupBox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerFormLabel);
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
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox postalCode;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.TextBox addressLine2;
        private System.Windows.Forms.TextBox addressLine1;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.RadioButton activeCustomer;
        private System.Windows.Forms.RadioButton inactiveCustomer;
    }
}