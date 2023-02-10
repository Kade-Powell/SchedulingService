
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monthlyCalendarDataGrid = new System.Windows.Forms.DataGridView();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.monthCalendarView = new System.Windows.Forms.TabPage();
            this.weekCalendarView = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.monthViewLabel = new System.Windows.Forms.Label();
            this.weekViewLabel = new System.Windows.Forms.Label();
            this.deleteAppointmentMonthButton = new System.Windows.Forms.Button();
            this.modifyAppointmentMonthButton = new System.Windows.Forms.Button();
            this.addAppointmentMonthButton = new System.Windows.Forms.Button();
            this.deleteAppointmentWeekButton = new System.Windows.Forms.Button();
            this.modifyAppointmentWeekButton = new System.Windows.Forms.Button();
            this.addAppointmentWeekButton = new System.Windows.Forms.Button();
            this.weeklyCalendarDataGrid.SuspendLayout();
            this.appointmentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.customerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyCalendarDataGrid)).BeginInit();
            this.monthCalendarView.SuspendLayout();
            this.weekCalendarView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // weeklyCalendarDataGrid
            // 
            this.weeklyCalendarDataGrid.Controls.Add(this.appointmentTab);
            this.weeklyCalendarDataGrid.Controls.Add(this.customerTab);
            this.weeklyCalendarDataGrid.Controls.Add(this.monthCalendarView);
            this.weeklyCalendarDataGrid.Controls.Add(this.weekCalendarView);
            this.weeklyCalendarDataGrid.Location = new System.Drawing.Point(109, 57);
            this.weeklyCalendarDataGrid.Name = "weeklyCalendarDataGrid";
            this.weeklyCalendarDataGrid.SelectedIndex = 0;
            this.weeklyCalendarDataGrid.Size = new System.Drawing.Size(911, 403);
            this.weeklyCalendarDataGrid.TabIndex = 0;
            // 
            // appointmentTab
            // 
            this.appointmentTab.Controls.Add(this.appointmentLabel);
            this.appointmentTab.Controls.Add(this.deleteAppointmentButton);
            this.appointmentTab.Controls.Add(this.modifyAppointmentButton);
            this.appointmentTab.Controls.Add(this.addAppointmentButton);
            this.appointmentTab.Controls.Add(this.appointmentDataGridView);
            this.appointmentTab.Location = new System.Drawing.Point(4, 22);
            this.appointmentTab.Name = "appointmentTab";
            this.appointmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentTab.Size = new System.Drawing.Size(903, 377);
            this.appointmentTab.TabIndex = 0;
            this.appointmentTab.Text = "Appointments";
            this.appointmentTab.UseVisualStyleBackColor = true;
            // 
            // appointmentLabel
            // 
            this.appointmentLabel.AutoSize = true;
            this.appointmentLabel.Location = new System.Drawing.Point(20, 19);
            this.appointmentLabel.Name = "appointmentLabel";
            this.appointmentLabel.Size = new System.Drawing.Size(113, 13);
            this.appointmentLabel.TabIndex = 6;
            this.appointmentLabel.Text = "Manage Appointments";
            // 
            // deleteAppointmentButton
            // 
            this.deleteAppointmentButton.Location = new System.Drawing.Point(757, 332);
            this.deleteAppointmentButton.Name = "deleteAppointmentButton";
            this.deleteAppointmentButton.Size = new System.Drawing.Size(140, 23);
            this.deleteAppointmentButton.TabIndex = 5;
            this.deleteAppointmentButton.Text = "Delete";
            this.deleteAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // modifyAppointmentButton
            // 
            this.modifyAppointmentButton.Location = new System.Drawing.Point(362, 332);
            this.modifyAppointmentButton.Name = "modifyAppointmentButton";
            this.modifyAppointmentButton.Size = new System.Drawing.Size(140, 23);
            this.modifyAppointmentButton.TabIndex = 4;
            this.modifyAppointmentButton.Text = "Modify";
            this.modifyAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.Location = new System.Drawing.Point(6, 332);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(140, 23);
            this.addAppointmentButton.TabIndex = 3;
            this.addAppointmentButton.Text = "Add";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.AllowUserToAddRows = false;
            this.appointmentDataGridView.AllowUserToDeleteRows = false;
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Location = new System.Drawing.Point(6, 53);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.ReadOnly = true;
            this.appointmentDataGridView.Size = new System.Drawing.Size(891, 262);
            this.appointmentDataGridView.TabIndex = 2;
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.label1);
            this.customerTab.Controls.Add(this.button1);
            this.customerTab.Controls.Add(this.button2);
            this.customerTab.Controls.Add(this.button3);
            this.customerTab.Controls.Add(this.dataGridView1);
            this.customerTab.Location = new System.Drawing.Point(4, 22);
            this.customerTab.Name = "customerTab";
            this.customerTab.Padding = new System.Windows.Forms.Padding(3);
            this.customerTab.Size = new System.Drawing.Size(903, 377);
            this.customerTab.TabIndex = 1;
            this.customerTab.Text = "Customers ";
            this.customerTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Manage Customers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(757, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(891, 262);
            this.dataGridView1.TabIndex = 6;
            // 
            // monthlyCalendarDataGrid
            // 
            this.monthlyCalendarDataGrid.AllowUserToAddRows = false;
            this.monthlyCalendarDataGrid.AllowUserToDeleteRows = false;
            this.monthlyCalendarDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthlyCalendarDataGrid.Location = new System.Drawing.Point(6, 60);
            this.monthlyCalendarDataGrid.Name = "monthlyCalendarDataGrid";
            this.monthlyCalendarDataGrid.ReadOnly = true;
            this.monthlyCalendarDataGrid.Size = new System.Drawing.Size(891, 264);
            this.monthlyCalendarDataGrid.TabIndex = 1;
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Location = new System.Drawing.Point(12, 57);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(0, 13);
            this.calendarLabel.TabIndex = 2;
            // 
            // monthCalendarView
            // 
            this.monthCalendarView.Controls.Add(this.deleteAppointmentMonthButton);
            this.monthCalendarView.Controls.Add(this.modifyAppointmentMonthButton);
            this.monthCalendarView.Controls.Add(this.addAppointmentMonthButton);
            this.monthCalendarView.Controls.Add(this.monthViewLabel);
            this.monthCalendarView.Controls.Add(this.monthlyCalendarDataGrid);
            this.monthCalendarView.Location = new System.Drawing.Point(4, 22);
            this.monthCalendarView.Name = "monthCalendarView";
            this.monthCalendarView.Padding = new System.Windows.Forms.Padding(3);
            this.monthCalendarView.Size = new System.Drawing.Size(903, 377);
            this.monthCalendarView.TabIndex = 2;
            this.monthCalendarView.Text = "Appointments By Month";
            this.monthCalendarView.UseVisualStyleBackColor = true;
            // 
            // weekCalendarView
            // 
            this.weekCalendarView.Controls.Add(this.deleteAppointmentWeekButton);
            this.weekCalendarView.Controls.Add(this.modifyAppointmentWeekButton);
            this.weekCalendarView.Controls.Add(this.addAppointmentWeekButton);
            this.weekCalendarView.Controls.Add(this.weekViewLabel);
            this.weekCalendarView.Controls.Add(this.dataGridView2);
            this.weekCalendarView.Location = new System.Drawing.Point(4, 22);
            this.weekCalendarView.Name = "weekCalendarView";
            this.weekCalendarView.Padding = new System.Windows.Forms.Padding(3);
            this.weekCalendarView.Size = new System.Drawing.Size(903, 377);
            this.weekCalendarView.TabIndex = 3;
            this.weekCalendarView.Text = "Appointments By Week";
            this.weekCalendarView.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(891, 264);
            this.dataGridView2.TabIndex = 2;
            // 
            // monthViewLabel
            // 
            this.monthViewLabel.AutoSize = true;
            this.monthViewLabel.Location = new System.Drawing.Point(6, 23);
            this.monthViewLabel.Name = "monthViewLabel";
            this.monthViewLabel.Size = new System.Drawing.Size(119, 13);
            this.monthViewLabel.TabIndex = 7;
            this.monthViewLabel.Text = "Appointments By Month";
            // 
            // weekViewLabel
            // 
            this.weekViewLabel.AutoSize = true;
            this.weekViewLabel.Location = new System.Drawing.Point(27, 22);
            this.weekViewLabel.Name = "weekViewLabel";
            this.weekViewLabel.Size = new System.Drawing.Size(118, 13);
            this.weekViewLabel.TabIndex = 8;
            this.weekViewLabel.Text = "Appointments By Week";
            // 
            // deleteAppointmentMonthButton
            // 
            this.deleteAppointmentMonthButton.Location = new System.Drawing.Point(757, 339);
            this.deleteAppointmentMonthButton.Name = "deleteAppointmentMonthButton";
            this.deleteAppointmentMonthButton.Size = new System.Drawing.Size(140, 23);
            this.deleteAppointmentMonthButton.TabIndex = 10;
            this.deleteAppointmentMonthButton.Text = "Delete";
            this.deleteAppointmentMonthButton.UseVisualStyleBackColor = true;
            // 
            // modifyAppointmentMonthButton
            // 
            this.modifyAppointmentMonthButton.Location = new System.Drawing.Point(362, 339);
            this.modifyAppointmentMonthButton.Name = "modifyAppointmentMonthButton";
            this.modifyAppointmentMonthButton.Size = new System.Drawing.Size(140, 23);
            this.modifyAppointmentMonthButton.TabIndex = 9;
            this.modifyAppointmentMonthButton.Text = "Modify";
            this.modifyAppointmentMonthButton.UseVisualStyleBackColor = true;
            // 
            // addAppointmentMonthButton
            // 
            this.addAppointmentMonthButton.Location = new System.Drawing.Point(6, 339);
            this.addAppointmentMonthButton.Name = "addAppointmentMonthButton";
            this.addAppointmentMonthButton.Size = new System.Drawing.Size(140, 23);
            this.addAppointmentMonthButton.TabIndex = 8;
            this.addAppointmentMonthButton.Text = "Add";
            this.addAppointmentMonthButton.UseVisualStyleBackColor = true;
            // 
            // deleteAppointmentWeekButton
            // 
            this.deleteAppointmentWeekButton.Location = new System.Drawing.Point(757, 335);
            this.deleteAppointmentWeekButton.Name = "deleteAppointmentWeekButton";
            this.deleteAppointmentWeekButton.Size = new System.Drawing.Size(140, 23);
            this.deleteAppointmentWeekButton.TabIndex = 11;
            this.deleteAppointmentWeekButton.Text = "Delete";
            this.deleteAppointmentWeekButton.UseVisualStyleBackColor = true;
            // 
            // modifyAppointmentWeekButton
            // 
            this.modifyAppointmentWeekButton.Location = new System.Drawing.Point(362, 335);
            this.modifyAppointmentWeekButton.Name = "modifyAppointmentWeekButton";
            this.modifyAppointmentWeekButton.Size = new System.Drawing.Size(140, 23);
            this.modifyAppointmentWeekButton.TabIndex = 10;
            this.modifyAppointmentWeekButton.Text = "Modify";
            this.modifyAppointmentWeekButton.UseVisualStyleBackColor = true;
            // 
            // addAppointmentWeekButton
            // 
            this.addAppointmentWeekButton.Location = new System.Drawing.Point(6, 335);
            this.addAppointmentWeekButton.Name = "addAppointmentWeekButton";
            this.addAppointmentWeekButton.Size = new System.Drawing.Size(140, 23);
            this.addAppointmentWeekButton.TabIndex = 9;
            this.addAppointmentWeekButton.Text = "Add";
            this.addAppointmentWeekButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 488);
            this.Controls.Add(this.calendarLabel);
            this.Controls.Add(this.weeklyCalendarDataGrid);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.weeklyCalendarDataGrid.ResumeLayout(false);
            this.appointmentTab.ResumeLayout(false);
            this.appointmentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.customerTab.ResumeLayout(false);
            this.customerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyCalendarDataGrid)).EndInit();
            this.monthCalendarView.ResumeLayout(false);
            this.monthCalendarView.PerformLayout();
            this.weekCalendarView.ResumeLayout(false);
            this.weekCalendarView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl weeklyCalendarDataGrid;
		private System.Windows.Forms.TabPage appointmentTab;
		private System.Windows.Forms.DataGridView appointmentDataGridView;
		private System.Windows.Forms.TabPage customerTab;
		private System.Windows.Forms.DataGridView monthlyCalendarDataGrid;
		private System.Windows.Forms.Button deleteAppointmentButton;
		private System.Windows.Forms.Button modifyAppointmentButton;
		private System.Windows.Forms.Button addAppointmentButton;
		private System.Windows.Forms.Label calendarLabel;
		private System.Windows.Forms.Label appointmentLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage monthCalendarView;
        private System.Windows.Forms.TabPage weekCalendarView;
        private System.Windows.Forms.DataGridView dataGridView2;
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