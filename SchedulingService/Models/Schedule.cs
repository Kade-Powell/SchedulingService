using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingService.Models
{
    public class Schedule
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public List<Appointment> UsersAppointments = new List<Appointment>();
        public Schedule(int UserId, string Username, Appointment appointment)
        {
            this.UserId = UserId;
            this.Username = Username;
            this.UsersAppointments.Add(appointment);
        }
    }
}
