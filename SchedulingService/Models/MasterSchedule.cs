using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingService.Models
{
    
    public class MasterSchedule
    {
        public Dictionary<int, Schedule> UsersSchedules = new Dictionary<int, Schedule>();
        private BindingList<Appointment> AllAppointments = new BindingList<Appointment>();

        public MasterSchedule()
        {
            //get all appointments from DB
            //get all appointments for current user
            string query = $"SELECT * FROM client_schedule.appointment";
            MySqlConnection c = new MySqlConnection("server=localhost;user=root;database=client_schedule;port=3306;password=Passw0rd!");
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    AllAppointments.Add(new Appointment(
                        appointmentId: Convert.ToInt32(rdr.GetValue(0)),
                        customerId: Convert.ToInt32(rdr.GetValue(1)),
                        userId: Convert.ToInt32(rdr.GetValue(2)),
                        title: rdr.GetValue(3).ToString(),
                        description: rdr.GetValue(4).ToString(),
                        location: rdr.GetValue(5).ToString(),
                        contact: rdr.GetValue(6).ToString(),
                        type: rdr.GetValue(7).ToString(),
                        url: rdr.GetValue(8).ToString(),
                        start: rdr.GetDateTime(9).ToLocalTime(),
                        end: rdr.GetDateTime(10).ToLocalTime(),
                        createDate: rdr.GetDateTime(11).ToLocalTime(),
                        createdBy: rdr.GetValue(12).ToString(),
                        lastUpdate: rdr.GetDateTime(13).ToLocalTime(),
                        lastUpdateBy: rdr.GetValue(14).ToString()
                        )
                    );
                }
            }
            rdr.Close();
            c.Close();
            //parse and place into UsersSchedules
            foreach(Appointment appointment in AllAppointments)
            {
                if (UsersSchedules.ContainsKey(appointment.userId))
                {
                    //we have an entry for this user, just add the appointment to their list
                    UsersSchedules[appointment.userId].UsersAppointments.Add(appointment);
                }
                else
                {
                    //no user entry for this userid make new schedule entry and add appointment
                    UsersSchedules.Add(appointment.userId, new Schedule(UserId: appointment.userId, Username: getUsernameFromId(appointment.userId), appointment));
                }
            }

        }

        public string getUsernameFromId(int userId) 
        {
            string username= "";
            string query = $"SELECT * FROM client_schedule.user WHERE `userId` = '{userId}'";
            MySqlConnection c = new MySqlConnection("server=localhost;user=root;database=client_schedule;port=3306;password=Passw0rd!");
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (!rdr.HasRows)
            {
                rdr.Close();
                c.Close();
                throw new Exception("User Not Found");
            }
            else
            {
                while (rdr.Read())
                {
                    username = rdr.GetValue(1).ToString();
                }
            }
            rdr.Close();
            c.Close();
            return username;
        }
    }

    
}
