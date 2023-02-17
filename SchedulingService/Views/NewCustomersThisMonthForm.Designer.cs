
namespace SchedulingService.Views
{
    partial class NewCustomersThisMonthForm
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
            this.newCustomerThisMonthLabel = new System.Windows.Forms.Label();
            this.newCustomerListView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.newCustomerListView)).BeginInit();
            this.SuspendLayout();
            // 
            // newCustomerThisMonthLabel
            // 
            this.newCustomerThisMonthLabel.AutoSize = true;
            this.newCustomerThisMonthLabel.Location = new System.Drawing.Point(12, 9);
            this.newCustomerThisMonthLabel.Name = "newCustomerThisMonthLabel";
            this.newCustomerThisMonthLabel.Size = new System.Drawing.Size(225, 21);
            this.newCustomerThisMonthLabel.TabIndex = 0;
            this.newCustomerThisMonthLabel.Text = "New Customers This Month";
            // 
            // newCustomerListView
            // 
            this.newCustomerListView.AllowUserToAddRows = false;
            this.newCustomerListView.AllowUserToDeleteRows = false;
            this.newCustomerListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.newCustomerListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newCustomerListView.Location = new System.Drawing.Point(12, 33);
            this.newCustomerListView.Name = "newCustomerListView";
            this.newCustomerListView.RowHeadersWidth = 51;
            this.newCustomerListView.RowTemplate.Height = 24;
            this.newCustomerListView.Size = new System.Drawing.Size(1167, 405);
            this.newCustomerListView.TabIndex = 1;
            // 
            // NewCustomersThisMonthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 450);
            this.Controls.Add(this.newCustomerListView);
            this.Controls.Add(this.newCustomerThisMonthLabel);
            this.Name = "NewCustomersThisMonthForm";
            this.Text = "NewCustomersThisMonthForm";
            ((System.ComponentModel.ISupportInitialize)(this.newCustomerListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newCustomerThisMonthLabel;
        private System.Windows.Forms.DataGridView newCustomerListView;
    }
}