
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.appointmentTab = new System.Windows.Forms.TabPage();
			this.customerTab = new System.Windows.Forms.TabPage();
			this.monthlyCalendarDataGrid = new System.Windows.Forms.DataGridView();
			this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
			this.addAppointmentButton = new System.Windows.Forms.Button();
			this.modifyAppointmentButton = new System.Windows.Forms.Button();
			this.deleteAppointmentButton = new System.Windows.Forms.Button();
			this.calendarLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.appointmentLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.appointmentTab.SuspendLayout();
			this.customerTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.monthlyCalendarDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.appointmentTab);
			this.tabControl1.Controls.Add(this.customerTab);
			this.tabControl1.Location = new System.Drawing.Point(595, 51);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(528, 403);
			this.tabControl1.TabIndex = 0;
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
			this.appointmentTab.Size = new System.Drawing.Size(520, 377);
			this.appointmentTab.TabIndex = 0;
			this.appointmentTab.Text = "Appointments";
			this.appointmentTab.UseVisualStyleBackColor = true;
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
			this.customerTab.Size = new System.Drawing.Size(520, 377);
			this.customerTab.TabIndex = 1;
			this.customerTab.Text = "Customers ";
			this.customerTab.UseVisualStyleBackColor = true;
			// 
			// monthlyCalendarDataGrid
			// 
			this.monthlyCalendarDataGrid.AllowUserToAddRows = false;
			this.monthlyCalendarDataGrid.AllowUserToDeleteRows = false;
			this.monthlyCalendarDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.monthlyCalendarDataGrid.Location = new System.Drawing.Point(12, 73);
			this.monthlyCalendarDataGrid.Name = "monthlyCalendarDataGrid";
			this.monthlyCalendarDataGrid.ReadOnly = true;
			this.monthlyCalendarDataGrid.Size = new System.Drawing.Size(547, 381);
			this.monthlyCalendarDataGrid.TabIndex = 1;
			// 
			// appointmentDataGridView
			// 
			this.appointmentDataGridView.AllowUserToAddRows = false;
			this.appointmentDataGridView.AllowUserToDeleteRows = false;
			this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.appointmentDataGridView.Location = new System.Drawing.Point(23, 53);
			this.appointmentDataGridView.Name = "appointmentDataGridView";
			this.appointmentDataGridView.ReadOnly = true;
			this.appointmentDataGridView.Size = new System.Drawing.Size(475, 262);
			this.appointmentDataGridView.TabIndex = 2;
			// 
			// addAppointmentButton
			// 
			this.addAppointmentButton.Location = new System.Drawing.Point(23, 332);
			this.addAppointmentButton.Name = "addAppointmentButton";
			this.addAppointmentButton.Size = new System.Drawing.Size(140, 23);
			this.addAppointmentButton.TabIndex = 3;
			this.addAppointmentButton.Text = "Add";
			this.addAppointmentButton.UseVisualStyleBackColor = true;
			// 
			// modifyAppointmentButton
			// 
			this.modifyAppointmentButton.Location = new System.Drawing.Point(193, 332);
			this.modifyAppointmentButton.Name = "modifyAppointmentButton";
			this.modifyAppointmentButton.Size = new System.Drawing.Size(140, 23);
			this.modifyAppointmentButton.TabIndex = 4;
			this.modifyAppointmentButton.Text = "Modify";
			this.modifyAppointmentButton.UseVisualStyleBackColor = true;
			// 
			// deleteAppointmentButton
			// 
			this.deleteAppointmentButton.Location = new System.Drawing.Point(358, 332);
			this.deleteAppointmentButton.Name = "deleteAppointmentButton";
			this.deleteAppointmentButton.Size = new System.Drawing.Size(140, 23);
			this.deleteAppointmentButton.TabIndex = 5;
			this.deleteAppointmentButton.Text = "Delete";
			this.deleteAppointmentButton.UseVisualStyleBackColor = true;
			// 
			// calendarLabel
			// 
			this.calendarLabel.AutoSize = true;
			this.calendarLabel.Location = new System.Drawing.Point(12, 57);
			this.calendarLabel.Name = "calendarLabel";
			this.calendarLabel.Size = new System.Drawing.Size(49, 13);
			this.calendarLabel.TabIndex = 2;
			this.calendarLabel.Text = "Calendar";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(358, 331);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Delete";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(193, 331);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(140, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Modify";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(23, 331);
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
			this.dataGridView1.Location = new System.Drawing.Point(23, 52);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(475, 262);
			this.dataGridView1.TabIndex = 6;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Manage Customers";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1135, 488);
			this.Controls.Add(this.calendarLabel);
			this.Controls.Add(this.monthlyCalendarDataGrid);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.tabControl1.ResumeLayout(false);
			this.appointmentTab.ResumeLayout(false);
			this.appointmentTab.PerformLayout();
			this.customerTab.ResumeLayout(false);
			this.customerTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.monthlyCalendarDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
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
	}
}