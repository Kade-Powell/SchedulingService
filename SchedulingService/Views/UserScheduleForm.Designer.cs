
namespace SchedulingService.Views
{
    partial class UserScheduleForm
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
            this.userScheduleDataGrid = new System.Windows.Forms.DataGridView();
            this.UserScheduleLabel = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.userScheduleDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // userScheduleDataGrid
            // 
            this.userScheduleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userScheduleDataGrid.Location = new System.Drawing.Point(12, 75);
            this.userScheduleDataGrid.Name = "userScheduleDataGrid";
            this.userScheduleDataGrid.RowHeadersWidth = 51;
            this.userScheduleDataGrid.RowTemplate.Height = 24;
            this.userScheduleDataGrid.Size = new System.Drawing.Size(1152, 363);
            this.userScheduleDataGrid.TabIndex = 0;
            this.userScheduleDataGrid.Visible = false;
            // 
            // UserScheduleLabel
            // 
            this.UserScheduleLabel.AutoSize = true;
            this.UserScheduleLabel.Location = new System.Drawing.Point(12, 9);
            this.UserScheduleLabel.Name = "UserScheduleLabel";
            this.UserScheduleLabel.Size = new System.Drawing.Size(191, 17);
            this.UserScheduleLabel.TabIndex = 1;
            this.UserScheduleLabel.Text = "View Schedule By Consultant";
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(423, 45);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(282, 24);
            this.userComboBox.TabIndex = 2;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // UserScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 450);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.UserScheduleLabel);
            this.Controls.Add(this.userScheduleDataGrid);
            this.Name = "UserScheduleForm";
            this.Text = "UserScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.userScheduleDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userScheduleDataGrid;
        private System.Windows.Forms.Label UserScheduleLabel;
        private System.Windows.Forms.ComboBox userComboBox;
    }
}