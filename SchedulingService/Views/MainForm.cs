using SchedulingService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingService.Views
{
	public partial class MainForm : Form
	{
		public AppState State;
		private BindingList<Appointment> MonthlyDataSource = new BindingList<Appointment>();
		private BindingList<Appointment> WeeklyDataSource = new BindingList<Appointment>();

		public MainForm(int UserId)
		{
			InitializeComponent();
			//init app state
			State = new AppState(UserId);
			appointmentDataGridView.DataSource = State.Appointments;
			customerDataGridView.DataSource = State.Customers;
			monthlyCalendarDataGridView.DataSource = MonthlyDataSource;
			weeklyCalendarDataGridView.DataSource = WeeklyDataSource;
		}

        private void weeklyCalendarDataGrid_Selected(object sender, TabControlEventArgs e)
        {
			calculateMonthly();
			calculateWeekly();
        }
		private void calculateMonthly()
        {
			foreach(Appointment appointment in State.Appointments)
            {
				if(appointment.start.Month == DateTime.Now.Month && appointment.start.Year == DateTime.Now.Year)
                {
					if (!MonthlyDataSource.Contains(appointment))
					{
						MonthlyDataSource.Add(appointment);
					}
                }

			}
			
		}
		private void calculateWeekly()
        {
			//get current week date range
			TimeSpan thisWeek = new TimeSpan(0, 0, 0, 0);
			IEnumerable<DateTime> currentWeek = Util.Daily(thisWeek);
			foreach (Appointment appointment in State.Appointments)
			{
				foreach(DateTime day in currentWeek)
                {
					if (appointment.start.GetDateTime().Date == day.Date)
					{
						if (!WeeklyDataSource.Contains(appointment)) { WeeklyDataSource.Add(appointment); }
					}
				}
			}
		}
    }
}
