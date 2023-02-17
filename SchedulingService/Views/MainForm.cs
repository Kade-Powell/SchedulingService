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


		public MainForm(int UserId, string userName)
		{
			InitializeComponent();
			//init app state
			State = new AppState(UserId, userName);
			appointmentDataGridView.DataSource = State.Appointments;
			customerDataGridView.DataSource = State.Customers;
			weeklyCalendarDataGridView.DataSource = State.WeeklyAppointments;
			monthlyCalendarDataGridView.DataSource = State.MonthlyAppointments;
			var (hasUrgentMeeting, messages) = State.checkForUrgentAppointments();

			if (hasUrgentMeeting)
            {
				foreach(string message in messages)
                {
					MessageBox.Show(message);
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
			CustomerForm customerForm = new CustomerForm(State: State);
			customerForm.StartPosition = FormStartPosition.CenterParent;
			customerForm.ShowDialog();
        }

        private void modifyCustomerButton_Click(object sender, EventArgs e)
        {
			Customer currentCustomer = (Customer)customerDataGridView.CurrentRow.DataBoundItem;


			CustomerForm customerForm = new CustomerForm(State: State, modifyMode: true, currentCustomer: currentCustomer);
			customerForm.StartPosition = FormStartPosition.CenterParent;
			customerForm.ShowDialog();
		}

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {

			Customer currentCustomer = (Customer)customerDataGridView.CurrentRow.DataBoundItem;
			//check if customer id is in use by any appointments first, if not delete
			List<string> targetsAppointmentIds = new List<string>();

			foreach (Appointment appointment in State.AllUsersAppointments)
			{ 
				if (appointment.customerId == currentCustomer.customerId)
				{
					targetsAppointmentIds.Add(appointment.appointmentId.ToString());
				}
			}

            if (targetsAppointmentIds.Count != 0)
            {
				string msgString = $"Unable to delete {currentCustomer.customerName} because they have appointments scheduled \n Appointment IDs: ";
				//lambda to shorten expression and make building string easier
				targetsAppointmentIds.ForEach(id => msgString += $" {id} " );
				MessageBox.Show(msgString);
            }
            else
            {
				State.deleteCustomer(currentCustomer);
			}
			
			
		}

        private void addAppointmentMonthButton_Click(object sender, EventArgs e)
        {
			AppointmentForm appointmentForm = new AppointmentForm(State);
			appointmentForm.StartPosition = FormStartPosition.CenterParent;
			appointmentForm.ShowDialog();
		}

        private void modifyAppointmentMonthButton_Click(object sender, EventArgs e)
        {
			Appointment currentAppointment = (Appointment) monthlyCalendarDataGridView.CurrentRow.DataBoundItem;
			AppointmentForm appointmentForm = new AppointmentForm(State, modifyMode: true, appointment: currentAppointment);
			appointmentForm.StartPosition = FormStartPosition.CenterParent;
			appointmentForm.ShowDialog();
		}

        private void deleteAppointmentMonthButton_Click(object sender, EventArgs e)
        {
			Appointment currentAppointment = (Appointment)monthlyCalendarDataGridView.CurrentRow.DataBoundItem;
			State.deleteAppointment(currentAppointment);
		}

        private void addAppointmentWeekButton_Click(object sender, EventArgs e)
        {
			AppointmentForm appointmentForm = new AppointmentForm(State);
			appointmentForm.StartPosition = FormStartPosition.CenterParent;
			appointmentForm.ShowDialog();
		}

        private void modifyAppointmentWeekButton_Click(object sender, EventArgs e)
        {
			Appointment currentAppointment = (Appointment)weeklyCalendarDataGridView.CurrentRow.DataBoundItem;
			AppointmentForm appointmentForm = new AppointmentForm(State, modifyMode: true, appointment: currentAppointment);
			appointmentForm.StartPosition = FormStartPosition.CenterParent;
			appointmentForm.ShowDialog();
		}
		private void deleteAppointmentWeekButton_Click(object sender, EventArgs e)
        {
			Appointment currentAppointment = (Appointment)weeklyCalendarDataGridView.CurrentRow.DataBoundItem;
			State.deleteAppointment(currentAppointment);
		}

        private void closeMain_Click(object sender, EventArgs e)
        {
			Close();
        }

        private void reportAppointmentTypesByMonthButton_Click(object sender, EventArgs e)
        {
			AppByMonthForm reportsForm = new AppByMonthForm(State);
			reportsForm.StartPosition = FormStartPosition.CenterParent;
			reportsForm.ShowDialog();
		}

        private void viewScheduleForUsers_Click(object sender, EventArgs e)
        {
			UserScheduleForm scheduleReport = new UserScheduleForm();
			scheduleReport.StartPosition = FormStartPosition.CenterParent;
			scheduleReport.ShowDialog();
		}

        private void newCustomerThisMonthButton_Click(object sender, EventArgs e)
        {
			NewCustomersThisMonthForm nctmForm = new NewCustomersThisMonthForm();
			nctmForm.StartPosition = FormStartPosition.CenterParent;
			nctmForm.ShowDialog();
		}
    }
}
