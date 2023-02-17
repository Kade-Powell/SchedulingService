
namespace SchedulingService.Views
{
    partial class AppByMonthForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.numberOfAppointmentByMonthTable = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfAppointmentByMonthTable)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfAppointmentByMonthTable
            // 
            chartArea1.Name = "DefaultChartArea";
            this.numberOfAppointmentByMonthTable.ChartAreas.Add(chartArea1);
            this.numberOfAppointmentByMonthTable.Location = new System.Drawing.Point(12, 78);
            this.numberOfAppointmentByMonthTable.Name = "numberOfAppointmentByMonthTable";
            this.numberOfAppointmentByMonthTable.Size = new System.Drawing.Size(1338, 360);
            this.numberOfAppointmentByMonthTable.TabIndex = 0;
            this.numberOfAppointmentByMonthTable.TabStop = false;
            this.numberOfAppointmentByMonthTable.Text = "chart1";
            // 
            // AppByMonthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 450);
            this.Controls.Add(this.numberOfAppointmentByMonthTable);
            this.Name = "AppByMonthForm";
            this.Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfAppointmentByMonthTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart numberOfAppointmentByMonthTable;
    }
}