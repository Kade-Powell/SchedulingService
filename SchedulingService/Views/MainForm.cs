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

		public MainForm(int UserId, string userName)
		{
			InitializeComponent();
			//init app state
			State = new AppState(UserId, userName);
			appointmentDataGridView.DataSource = State.Appointments;
			customerDataGridView.DataSource = State.Customers;
			monthlyCalendarDataGridView.DataSource = MonthlyDataSource;
			weeklyCalendarDataGridView.DataSource = WeeklyDataSource;

			var (hasUrgentMeeting, messages) = State.checkForUrgentAppointments();

			if (hasUrgentMeeting)
            {
				foreach(string message in messages)
                {
					MessageBox.Show(message);
                }
            }
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
					if (appointment.start.Date == day.Date)
					{
						if (!WeeklyDataSource.Contains(appointment)) { WeeklyDataSource.Add(appointment); }
					}
				}
			}
		}

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
			AppointmentForm appointmentForm = new AppointmentForm(State);
			appointmentForm.StartPosition = FormStartPosition.CenterParent;
			appointmentForm.ShowDialog();
		}

        private void modifyAppointmentButton_Click(object sender, EventArgs e)
        {
			Appointment currentAppointment = (Appointment)appointmentDataGridView.CurrentRow.DataBoundItem;
			AppointmentForm appointmentForm = new AppointmentForm(State, modifyMode: true, appointment: currentAppointment);

			appointmentForm.StartPosition = FormStartPosition.CenterParent;
			appointmentForm.ShowDialog();
		}

        private void deleteAppointmentButton_Click(object sender, EventArgs e)
        {
			Appointment currentAppointment = (Appointment)appointmentDataGridView.CurrentRow.DataBoundItem;
			State.deleteAppointment(currentAppointment);
		}

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
			CustomerForm customerForm = new CustomerForm();
			customerForm.StartPosition = FormStartPosition.CenterParent;
			customerForm.ShowDialog();
        }

        private void modifyCustomerButton_Click(object sender, EventArgs e)
        {
			CustomerForm customerForm = new CustomerForm();
			customerForm.StartPosition = FormStartPosition.CenterParent;
			customerForm.ShowDialog();
		}

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
			//get current row's customer and remove from DB AND Sync State!
		}

        private void addAppointmentMonthButton_Click(object sender, EventArgs e)
        {
			AppointmentForm appointmentForm = new AppointmentForm(State);
			appointmentForm.StartPosition = FormStartPosition.CenterParent;
			appointmentForm.ShowDialog();
		}

        private void modifyAppointmentMonthButton_Click(object sender, EventArgs e)
        {
			AppointmentForm appointmentForm = new AppointmentForm(State);
			appointmentForm.StartPosition = FormStartPosition.CenterParent;
			appointmentForm.ShowDialog();
		}

        private void deleteAppointmentMonthButton_Click(object sender, EventArgs e)
        {
			//get current row's customer and remove from DB AND Sync State!
		}

        private void addAppointmentWeekButton_Click(object sender, EventArgs e)
        {
			AppointmentForm appointmentForm = new AppointmentForm(State);
			appointmentForm.StartPosition = FormStartPosition.CenterParent;
			appointmentForm.ShowDialog();
		}

        private void modifyAppointmentWeekButton_Click(object sender, EventArgs e)
        {
			AppointmentForm appointmentForm = new AppointmentForm(State);
			appointmentForm.StartPosition = FormStartPosition.CenterParent;
			appointmentForm.ShowDialog();
		}

        private void deleteAppointmentWeekButton_Click(object sender, EventArgs e)
        {
			//get current row's customer and remove from DB AND Sync State!
		}

        private void closeMain_Click(object sender, EventArgs e)
        {
			Close();
        }

        private void reportAppointmentTypesByMonthButton_Click(object sender, EventArgs e)
        {
			ReportsForm reportsForm = new ReportsForm(State);
			reportsForm.StartPosition = FormStartPosition.CenterParent;
			reportsForm.ShowDialog();
		}
    }
}
