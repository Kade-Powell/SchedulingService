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
                currentAppointment.start = this.start.Value.ToUniversalTime();
                currentAppointment.end = this.end.Value.ToUniversalTime();
                currentAppointment.lastUpdate = DateTime.Now.ToUniversalTime();
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
                   start: this.start.Value.ToUniversalTime(),
                   end: this.end.Value.ToUniversalTime(),
                   createDate: DateTime.Now.Date.ToUniversalTime(),
                   createdBy: MainState.currentUserName,
                   lastUpdate: DateTime.Now.ToUniversalTime(),
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
