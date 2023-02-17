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
    public partial class AppointmentForm : Form
    {
        private AppState MainState;
        public Boolean modifyMode;
        public Appointment currentAppointment;
        public AppointmentForm(AppState State, Boolean modifyMode = false, Appointment appointment = null)
        {
            InitializeComponent();
            //load customer options and set combo box
            customerId.DataSource = State.Customers;
            customerId.DisplayMember = "customerName";
            customerId.ValueMember = "customerId";
            MainState = State;
            this.modifyMode = modifyMode;
            currentAppointment = appointment;

            if (this.modifyMode) 
            {
                appointPageLabel.Text = "Modify Appointment" ;
                setFormFromAppointment(appointment);
            } 
            else { appointPageLabel.Text = "Add Appointment"; }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            /////// STARTS VALIDATION RULES
            /////check customer is an actual customer
            if (!(MainState.Customers.Contains(customerId.SelectedItem)))
            {
                MessageBox.Show("Please select a customer from the drop down.");
                return;
            }

            //check for outside of business hours
            TimeSpan businessHoursstart = TimeSpan.Parse("08:00"); // 8am
            TimeSpan BusinessHoursEnd = TimeSpan.Parse("17:00");   // 5pm
            TimeSpan startTime = start.Value.TimeOfDay;
            TimeSpan endTime = end.Value.TimeOfDay;

            if(start.Value.Date != end.Value.Date)
            {
                //start and end are not in the same day
                MessageBox.Show("Start and End Times Must Be In The Same Day");
                return;
            }
            if (startTime <= endTime)
            {
                // start and stop times are in the same day
                if (!(startTime >= businessHoursstart && startTime <= BusinessHoursEnd))
                {
                    // startTime is NOT between bus. hours start and stop
                    MessageBox.Show("Start time must be between 8:00am and 5:00pm");
                    return;
                }
                if (!(endTime >= businessHoursstart && endTime <= BusinessHoursEnd))
                {
                    // endTime is NOT between bus. hours start and stop
                    MessageBox.Show("End time must be between 8:00am and 5:00pm");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Start time should be less than the end time!");
                return;
            }

            //check is user has overlapping appointments
            foreach(Appointment appointment in MainState.Appointments)
            {
                bool overlap = start.Value < appointment.end && appointment.start < end.Value;
                if (overlap)
                {
                    //chec kif overlap is from current appointment
                    if(!(appointment.appointmentId == currentAppointment.appointmentId))
                    {
                        MessageBox.Show($"You have overlapping appointment times with appointment ID {appointment.appointmentId}");
                        return;
                    }
                   
                }
            }
            //check the start and stop times are greater than time now
            if(start.Value < DateTime.Now)
            {
                MessageBox.Show("Appointments can't be scheduled for earlier times than right now");
                return;
            }
            if (end.Value < DateTime.Now)
            {
                MessageBox.Show("Appointments can't be scheduled for earlier times than right now");
                return;
            }
            if(title.Text.Length < 1) { MessageBox.Show("Please Enter An Appointment Title"); return; }
            if (description.Text.Length < 1) { MessageBox.Show("Please Enter An Appointment Description"); return; }
            if (location.Text.Length < 1) { MessageBox.Show("Please Enter An Appointment Location"); return; }
            if (type.Text.Length < 1) { MessageBox.Show("Please Enter An Appointment Type"); return; }
            if (url.Text.Length < 1) { MessageBox.Show("Please Enter An Appointment URL or N/A if none"); return; }
            if (contact.Text.Length < 1) { MessageBox.Show("Please Enter An Appointment Contact"); return; }
            /////// ENDS VALIDATION RULES
            if (modifyMode)
            {
                currentAppointment.customerId = Convert.ToInt32(this.customerId.SelectedValue);
                currentAppointment.userId = MainState.currentUserId;
                currentAppointment.title = this.title.Text;
                currentAppointment.description = this.description.Text;
                currentAppointment.location = this.location.Text;
                currentAppointment.contact = this.contact.Text;
                currentAppointment.type = this.type.Text;
                currentAppointment.url = this.url.Text;
                currentAppointment.start = this.start.Value;
                currentAppointment.end = this.end.Value;
                currentAppointment.lastUpdateBy = MainState.currentUserName;

                MainState.updateAppointment(currentAppointment);

            }
            else
            {
                Appointment appointment = new Appointment(
                   appointmentId: MainState.nextAppointmentId(),
                   customerId: Convert.ToInt32(this.customerId.SelectedValue),
                   userId: MainState.currentUserId,
                   title: this.title.Text,
                   description: this.description.Text,
                   location: this.location.Text,
                   contact: this.contact.Text,
                   type: this.type.Text,
                   url: this.url.Text,
                   start: this.start.Value,
                   end: this.end.Value,
                   createDate: DateTime.Now.Date,
                   createdBy: MainState.currentUserName,
                  
                   lastUpdateBy: MainState.currentUserName
                   );
                MainState.addAppointment(appointment);
            }
            
            this.Close();
        }

        private void setFormFromAppointment(Appointment appointment)
        {
            this.customerId.SelectedValue = appointment.customerId;
            this.title.Text = appointment.title;
            this.description.Text = appointment.description;
            this.location.Text = appointment.location;
            this.type.Text = appointment.type;
            this.url.Text = appointment.url;
            this.start.Value = appointment.start;
            this.end.Value = appointment.end;
            this.contact.Text = appointment.contact;
        }
    }
}
