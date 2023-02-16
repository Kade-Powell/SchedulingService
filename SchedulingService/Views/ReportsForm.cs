using SchedulingService.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SchedulingService.Views
{
    public partial class ReportsForm : Form
    {
        public List<NumberOfAppointmentReport> numberOfAppointmentByMonth;
        public SortedList months = new SortedList();
        
        public ReportsForm(AppState appState)
        {
            InitializeComponent();
            months.Add(1, "January");
            months.Add(2, "February");
            months.Add(3, "March");
            months.Add(4, "April");
            months.Add(5, "May");
            months.Add(6, "June");
            months.Add(7, "July");
            months.Add(8, "August");
            months.Add(9, "September");
            months.Add(10, "October");
            months.Add(11, "November");
            months.Add(12, "December");
            numberOfAppointmentByMonth = getReport(appState);
            numberOfAppointmentByMonthTable.Titles.Add("Appointment Type By Month Chart");

            numberOfAppointmentByMonthTable.Legends.Add("Month");

            List<string> appointmentTypes = new List<string>();
            foreach (NumberOfAppointmentReport report in numberOfAppointmentByMonth)
            {
                if (!appointmentTypes.Contains(report.appointmentType)){ appointmentTypes.Add(report.appointmentType); }
            }
            foreach ( string month in months.Values)
            {
                Series series = numberOfAppointmentByMonthTable.Series.Add(month);
                series.Legend = "Month";
                series.SmartLabelStyle.Enabled = false;

                foreach(string appointmentType in appointmentTypes)
                {
                   int index = series.Points.AddXY(appointmentType, 0);
                }
            }
            
            foreach (NumberOfAppointmentReport report in numberOfAppointmentByMonth)
            {
                numberOfAppointmentByMonthTable.Series[report.month].Points.ElementAt(appointmentTypes.IndexOf(report.appointmentType)).SetValueY(report.quantity);
                DataPoint point = numberOfAppointmentByMonthTable.Series[report.month].Points.ElementAt(appointmentTypes.IndexOf(report.appointmentType));
                point.ToolTip = $"{report.quantity} {report.appointmentType} in {report.month}";
                point.Label = $"    {report.appointmentType} {report.month}";
                point.LabelToolTip = $"{report.quantity} {report.appointmentType} in {report.month}";
                point.LabelBackColor = Color.FromArgb(alpha: 128, Color.White);
                point.LabelAngle = 90;

            }


        }

        public List<NumberOfAppointmentReport> getReport(AppState appState)
        {
            List<NumberOfAppointmentReport> appointmentReports = new List<NumberOfAppointmentReport>();
            List<Hashtable> appointmentTypes = new List<Hashtable>();

            foreach (Appointment appointment in appState.Appointments)
            {
                int month = appointment.start.Month;
                bool duplicate = false;
                foreach (NumberOfAppointmentReport r in appointmentReports)
                {
                    if (r.month == months[month].ToString() && r.appointmentType == appointment.type)
                    {
                        duplicate = true;
                    }
                }
                if (!duplicate)
                {
                    NumberOfAppointmentReport report = new NumberOfAppointmentReport();
                    report.month = months[month].ToString();
                    report.appointmentType = appointment.type;
                    // Lambda used to simplify expression
                    report.quantity = appState.Appointments.Where(i => i.type == appointment.type && i.start.Month == month ).Count();

                    appointmentReports.Add(report);
                }
            }



            return appointmentReports;
        }
    }
}
