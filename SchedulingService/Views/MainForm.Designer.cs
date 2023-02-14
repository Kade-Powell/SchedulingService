
namespace SchedulingService.Views
{
	partial class MainForm
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
            this.weeklyCalendarDataGrid = new System.Windows.Forms.TabControl();
            this.appointmentTab = new System.Windows.Forms.TabPage();
            this.appointmentLabel = new System.Windows.Forms.Label();
            this.deleteAppointmentButton = new System.Windows.Forms.Button();
            this.modifyAppointmentButton = new System.Windows.Forms.Button();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.customerTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.monthCalendarView = new System.Windows.Forms.TabPage();
            this.addAppointmentMonthButton = new System.Windows.Forms.Button();
            this.monthViewLabel = new System.Windows.Forms.Label();
            this.deleteAppointmentMonthButton = new System.Windows.Forms.Button();
            this.modifyAppointmentMonthButton = new System.Windows.Forms.Button();
            this.monthlyCalendarDataGridView = new System.Windows.Forms.DataGridView();
            this.weekCalendarView = new System.Windows.Forms.TabPage();
            this.deleteAppointmentWeekButton = new System.Windows.Forms.Button();
            this.modifyAppointmentWeekButton = new System.Windows.Forms.Button();
            this.addAppointmentWeekButton = new System.Windows.Forms.Button();
            this.weekViewLabel = new System.Windows.Forms.Label();
            this.weeklyCalendarDataGridView = new System.Windows.Forms.DataGridView();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.weeklyCalendarDataGrid.SuspendLayout();
            this.appointmentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.customerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.monthCalendarView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyCalendarDataGridView)).BeginInit();
            this.weekCalendarView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyCalendarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // weeklyCalendarDataGrid
            // 
            this.weeklyCalendarDataGrid.Controls.Add(this.appointmentTab);
            this.weeklyCalendarDataGrid.Controls.Add(this.customerTab);
            this.weeklyCalendarDataGrid.Controls.Add(this.monthCalendarView);
            this.weeklyCalendarDataGrid.Controls.Add(this.weekCalendarView);
            this.weeklyCalendarDataGrid.Location = new System.Drawing.Point(19, 13);
            this.weeklyCalendarDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.weeklyCalendarDataGrid.Name = "weeklyCalendarDataGrid";
            this.weeklyCalendarDataGrid.SelectedIndex = 0;
            this.weeklyCalendarDataGrid.Size = new System.Drawing.Size(1674, 575);
            this.weeklyCalendarDataGrid.TabIndex = 0;
            this.weeklyCalendarDataGrid.Selected += new System.Windows.Forms.TabControlEventHandler(this.weeklyCalendarDataGrid_Selected);
            // 
            // appointmentTab
            // 
            this.appointmentTab.Controls.Add(this.appointmentLabel);
            this.appointmentTab.Controls.Add(this.deleteAppointmentButton);
            this.appointmentTab.Controls.Add(this.modifyAppointmentButton);
            this.appointmentTab.Controls.Add(this.addAppointmentButton);
            this.appointmentTab.Controls.Add(this.appointmentDataGridView);
            this.appointmentTab.Location = new System.Drawing.Point(4, 25);
            this.appointmentTab.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentTab.Name = "appointmentTab";
            this.appointmentTab.Padding = new System.Windows.Forms.Padding(4);
            this.appointmentTab.Size = new System.Drawing.Size(1666, 546);
            this.appointmentTab.TabIndex = 0;
            this.appointmentTab.Text = "Appointments";
            this.appointmentTab.UseVisualStyleBackColor = true;
            // 
            // appointmentLabel
            // 
            this.appointmentLabel.AutoSize = true;
            this.appointmentLabel.Location = new System.Drawing.Point(729, 32);
            this.appointmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appointmentLabel.Name = "appointmentLabel";
            this.appointmentLabel.Size = new System.Drawing.Size(149, 17);
            this.appointmentLabel.TabIndex = 6;
            this.appointmentLabel.Text = "Manage Appointments";
            // 
            // deleteAppointmentButton
            // 
            this.deleteAppointmentButton.Location = new System.Drawing.Point(1471, 510);
            this.deleteAppointmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteAppointmentButton.Name = "deleteAppointmentButton";
            this.deleteAppointmentButton.Size = new System.Drawing.Size(187, 28);
            this.deleteAppointmentButton.TabIndex = 5;
            this.deleteAppointmentButton.Text = "Delete";
            this.deleteAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // modifyAppointmentButton
            // 
            this.modifyAppointmentButton.Location = new System.Drawing.Point(732, 510);
            this.modifyAppointmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyAppointmentButton.Name = "modifyAppointmentButton";
            this.modifyAppointmentButton.Size = new System.Drawing.Size(187, 28);
            this.modifyAppointmentButton.TabIndex = 4;
            this.modifyAppointmentButton.Text = "Modify";
            this.modifyAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.Location = new System.Drawing.Point(8, 510);
            this.addAppointmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(187, 28);
            this.addAppointmentButton.TabIndex = 3;
            this.addAppointmentButton.Text = "Add";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.AllowUserToAddRows = false;
            this.appointmentDataGridView.AllowUserToDeleteRows = false;
            this.appointmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Location = new System.Drawing.Point(8, 53);
            this.appointmentDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.ReadOnly = true;
            this.appointmentDataGridView.RowHeadersWidth = 51;
            this.appointmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentDataGridView.Size = new System.Drawing.Size(1650, 449);
            this.appointmentDataGridView.TabIndex = 2;
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.label1);
            this.customerTab.Controls.Add(this.button1);
            this.customerTab.Controls.Add(this.button2);
            this.customerTab.Controls.Add(this.button3);
            this.customerTab.Controls.Add(this.customerDataGridView);
            this.customerTab.Location = new System.Drawing.Point(4, 25);
            this.customerTab.Margin = new System.Windows.Forms.Padding(4);
            this.customerTab.Name = "customerTab";
            this.customerTab.Padding = new System.Windows.Forms.Padding(4);
            this.customerTab.Size = new System.Drawing.Size(1666, 546);
            this.customerTab.TabIndex = 1;
            this.customerTab.Text = "Customers ";
            this.customerTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(753, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Manage Customers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1471, 510);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(756, 510);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 510);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(8, 53);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(1650, 449);
            this.customerDataGridView.TabIndex = 6;
            // 
            // monthCalendarView
            // 
            this.monthCalendarView.Controls.Add(this.addAppointmentMonthButton);
            this.monthCalendarView.Controls.Add(this.monthViewLabel);
            this.monthCalendarView.Controls.Add(this.deleteAppointmentMonthButton);
            this.monthCalendarView.Controls.Add(this.modifyAppointmentMonthButton);
            this.monthCalendarView.Controls.Add(this.monthlyCalendarDataGridView);
            this.monthCalendarView.Location = new System.Drawing.Point(4, 25);
            this.monthCalendarView.Margin = new System.Windows.Forms.Padding(4);
            this.monthCalendarView.Name = "monthCalendarView";
            this.monthCalendarView.Padding = new System.Windows.Forms.Padding(4);
            this.monthCalendarView.Size = new System.Drawing.Size(1666, 546);
            this.monthCalendarView.TabIndex = 2;
            this.monthCalendarView.Text = "Appointments By Month";
            this.monthCalendarView.UseVisualStyleBackColor = true;
            // 
            // addAppointmentMonthButton
            // 
            this.addAppointmentMonthButton.Location = new System.Drawing.Point(8, 510);
            this.addAppointmentMonthButton.Margin = new System.Windows.Forms.Padding(4);
            this.addAppointmentMonthButton.Name = "addAppointmentMonthButton";
            this.addAppointmentMonthButton.Size = new System.Drawing.Size(187, 28);
            this.addAppointmentMonthButton.TabIndex = 8;
            this.addAppointmentMonthButton.Text = "Add";
            this.addAppointmentMonthButton.UseVisualStyleBackColor = true;
            // 
            // monthViewLabel
            // 
            this.monthViewLabel.AutoSize = true;
            this.monthViewLabel.Location = new System.Drawing.Point(743, 32);
            this.monthViewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monthViewLabel.Name = "monthViewLabel";
            this.monthViewLabel.Size = new System.Drawing.Size(157, 17);
            this.monthViewLabel.TabIndex = 7;
            this.monthViewLabel.Text = "Appointments By Month";
            // 
            // deleteAppointmentMonthButton
            // 
            this.deleteAppointmentMonthButton.Location = new System.Drawing.Point(1471, 510);
            this.deleteAppointmentMonthButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteAppointmentMonthButton.Name = "deleteAppointmentMonthButton";
            this.deleteAppointmentMonthButton.Size = new System.Drawing.Size(187, 28);
            this.deleteAppointmentMonthButton.TabIndex = 10;
            this.deleteAppointmentMonthButton.Text = "Delete";
            this.deleteAppointmentMonthButton.UseVisualStyleBackColor = true;
            // 
            // modifyAppointmentMonthButton
            // 
            this.modifyAppointmentMonthButton.Location = new System.Drawing.Point(746, 510);
            this.modifyAppointmentMonthButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyAppointmentMonthButton.Name = "modifyAppointmentMonthButton";
            this.modifyAppointmentMonthButton.Size = new System.Drawing.Size(187, 28);
            this.modifyAppointmentMonthButton.TabIndex = 9;
            this.modifyAppointmentMonthButton.Text = "Modify";
            this.modifyAppointmentMonthButton.UseVisualStyleBackColor = true;
            // 
            // monthlyCalendarDataGridView
            // 
            this.monthlyCalendarDataGridView.AllowUserToAddRows = false;
            this.monthlyCalendarDataGridView.AllowUserToDeleteRows = false;
            this.monthlyCalendarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.monthlyCalendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthlyCalendarDataGridView.Location = new System.Drawing.Point(8, 53);
            this.monthlyCalendarDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.monthlyCalendarDataGridView.Name = "monthlyCalendarDataGridView";
            this.monthlyCalendarDataGridView.ReadOnly = true;
            this.monthlyCalendarDataGridView.RowHeadersWidth = 51;
            this.monthlyCalendarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.monthlyCalendarDataGridView.Size = new System.Drawing.Size(1650, 449);
            this.monthlyCalendarDataGridView.TabIndex = 1;
            // 
            // weekCalendarView
            // 
            this.weekCalendarView.Controls.Add(this.deleteAppointmentWeekButton);
            this.weekCalendarView.Controls.Add(this.modifyAppointmentWeekButton);
            this.weekCalendarView.Controls.Add(this.addAppointmentWeekButton);
            this.weekCalendarView.Controls.Add(this.weekViewLabel);
            this.weekCalendarView.Controls.Add(this.weeklyCalendarDataGridView);
            this.weekCalendarView.Location = new System.Drawing.Point(4, 25);
            this.weekCalendarView.Margin = new System.Windows.Forms.Padding(4);
            this.weekCalendarView.Name = "weekCalendarView";
            this.weekCalendarView.Padding = new System.Windows.Forms.Padding(4);
            this.weekCalendarView.Size = new System.Drawing.Size(1666, 546);
            this.weekCalendarView.TabIndex = 3;
            this.weekCalendarView.Text = "Appointments By Week";
            this.weekCalendarView.UseVisualStyleBackColor = true;
            // 
            // deleteAppointmentWeekButton
            // 
            this.deleteAppointmentWeekButton.Location = new System.Drawing.Point(1471, 510);
            this.deleteAppointmentWeekButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteAppointmentWeekButton.Name = "deleteAppointmentWeekButton";
            this.deleteAppointmentWeekButton.Size = new System.Drawing.Size(187, 28);
            this.deleteAppointmentWeekButton.TabIndex = 11;
            this.deleteAppointmentWeekButton.Text = "Delete";
            this.deleteAppointmentWeekButton.UseVisualStyleBackColor = true;
            // 
            // modifyAppointmentWeekButton
            // 
            this.modifyAppointmentWeekButton.Location = new System.Drawing.Point(743, 510);
            this.modifyAppointmentWeekButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyAppointmentWeekButton.Name = "modifyAppointmentWeekButton";
            this.modifyAppointmentWeekButton.Size = new System.Drawing.Size(187, 28);
            this.modifyAppointmentWeekButton.TabIndex = 10;
            this.modifyAppointmentWeekButton.Text = "Modify";
            this.modifyAppointmentWeekButton.UseVisualStyleBackColor = true;
            // 
            // addAppointmentWeekButton
            // 
            this.addAppointmentWeekButton.Location = new System.Drawing.Point(8, 510);
            this.addAppointmentWeekButton.Margin = new System.Windows.Forms.Padding(4);
            this.addAppointmentWeekButton.Name = "addAppointmentWeekButton";
            this.addAppointmentWeekButton.Size = new System.Drawing.Size(187, 28);
            this.addAppointmentWeekButton.TabIndex = 9;
            this.addAppointmentWeekButton.Text = "Add";
            this.addAppointmentWeekButton.UseVisualStyleBackColor = true;
            // 
            // weekViewLabel
            // 
            this.weekViewLabel.AutoSize = true;
            this.weekViewLabel.Location = new System.Drawing.Point(740, 32);
            this.weekViewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weekViewLabel.Name = "weekViewLabel";
            this.weekViewLabel.Size = new System.Drawing.Size(154, 17);
            this.weekViewLabel.TabIndex = 8;
            this.weekViewLabel.Text = "Appointments By Week";
            // 
            // weeklyCalendarDataGridView
            // 
            this.weeklyCalendarDataGridView.AllowUserToAddRows = false;
            this.weeklyCalendarDataGridView.AllowUserToDeleteRows = false;
            this.weeklyCalendarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.weeklyCalendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyCalendarDataGridView.Location = new System.Drawing.Point(8, 53);
            this.weeklyCalendarDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.weeklyCalendarDataGridView.Name = "weeklyCalendarDataGridView";
            this.weeklyCalendarDataGridView.ReadOnly = true;
            this.weeklyCalendarDataGridView.RowHeadersWidth = 51;
            this.weeklyCalendarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.weeklyCalendarDataGridView.Size = new System.Drawing.Size(1650, 449);
            this.weeklyCalendarDataGridView.TabIndex = 2;
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Location = new System.Drawing.Point(16, 70);
            this.calendarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(0, 17);
            this.calendarLabel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 601);
            this.Controls.Add(this.calendarLabel);
            this.Controls.Add(this.weeklyCalendarDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.weeklyCalendarDataGrid.ResumeLayout(false);
            this.appointmentTab.ResumeLayout(false);
            this.appointmentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.customerTab.ResumeLayout(false);
            this.customerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.monthCalendarView.ResumeLayout(false);
            this.monthCalendarView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyCalendarDataGridView)).EndInit();
            this.weekCalendarView.ResumeLayout(false);
            this.weekCalendarView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyCalendarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl weeklyCalendarDataGrid;
		private System.Windows.Forms.TabPage appointmentTab;
		private System.Windows.Forms.DataGridView appointmentDataGridView;
		private System.Windows.Forms.TabPage customerTab;
		private System.Windows.Forms.DataGridView monthlyCalendarDataGridView;
		private System.Windows.Forms.Button deleteAppointmentButton;
		private System.Windows.Forms.Button modifyAppointmentButton;
		private System.Windows.Forms.Button addAppointmentButton;
		private System.Windows.Forms.Label calendarLabel;
		private System.Windows.Forms.Label appointmentLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.TabPage monthCalendarView;
        private System.Windows.Forms.TabPage weekCalendarView;
        private System.Windows.Forms.DataGridView weeklyCalendarDataGridView;
        private System.Windows.Forms.Label monthViewLabel;
        private System.Windows.Forms.Label weekViewLabel;
        private System.Windows.Forms.Button deleteAppointmentMonthButton;
        private System.Windows.Forms.Button modifyAppointmentMonthButton;
        private System.Windows.Forms.Button addAppointmentMonthButton;
        private System.Windows.Forms.Button deleteAppointmentWeekButton;
        private System.Windows.Forms.Button modifyAppointmentWeekButton;
        private System.Windows.Forms.Button addAppointmentWeekButton;
    }
}