using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingService.Models
{
    public class AppState
    {
        public BindingList<Appointment> Appointments = new BindingList<Appointment>();
        public BindingList<Customer> Customers = new BindingList<Customer>();
        private static int currentUserId;
        public static string connectionString = "server=localhost;user=root;database=client_schedule;port=3306;password=Passw0rd!";

        public AppState(int UserId)
        {
            currentUserId = UserId;
            //currentUserName = getCurrentUserName(UserId);
            getUserAppointments();
            getCustomers();
        }

        //methods
        public void getUserAppointments()
        {
            //get all appointments for current user
            string query = $"SELECT * FROM client_schedule.appointment WHERE userId = {currentUserId}";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {   
                while (rdr.Read())
                {
                    Appointments.Add(new Appointment(
                        appointmentId: Convert.ToInt32(rdr.GetValue(0)),
                        customerId: Convert.ToInt32(rdr.GetValue(1)),
                        userId: Convert.ToInt32(rdr.GetValue(2)),
                        title: rdr.GetValue(3).ToString(),
                        description: rdr.GetValue(4).ToString(),
                        location: rdr.GetValue(5).ToString(),
                        contact: rdr.GetValue(6).ToString(),
                        type: rdr.GetValue(7).ToString(),
                        url: rdr.GetValue(8).ToString(),
                        start: rdr.GetMySqlDateTime(9),
                        end: rdr.GetMySqlDateTime(10),
                        createDate: rdr.GetMySqlDateTime(11),
                        createBy: rdr.GetValue(12).ToString(),
                        lastUpdate: rdr.GetMySqlDateTime(13),
                        lastUpdateBy: rdr.GetValue(14).ToString()
                        )
                    );
                }         
            }
            rdr.Close();
            c.Close();
        }
        public void getCustomers()
        {
            //get all appointments for current user
            string query = $"SELECT * FROM client_schedule.customer";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Customers.Add(new Customer(
                            customerId: Convert.ToInt32(rdr.GetValue(0)),
                            customerName: rdr.GetValue(1).ToString(),
                            addressId: Convert.ToInt32(rdr.GetValue(2)),
                            active: Convert.ToInt32(rdr.GetValue(3)),
                            createDate: rdr.GetMySqlDateTime(4),
                            createdBy: rdr.GetValue(5).ToString(),
                            lastUpdate: rdr.GetMySqlDateTime(6),
                            lastUpdateBy: rdr.GetValue(7).ToString()

                        ));
                }

            }
            rdr.Close();
            c.Close();
        }
        public int findCustomerId(string search)
        {
            int customerId;
            string query;
            if (int.TryParse(search, out customerId))
            {
                query = $"SELECT customerId FROM customer WHERE customerId = '{search.ToString()}'";
            }
            else
            {
                query = $"SELECT customerId FROM customer WHERE customerName LIKE '{search}'";
            }
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                customerId = Convert.ToInt32(rdr[0]);
                rdr.Close(); c.Close();
                return customerId;
            }
            return 0;
        }

        
    }


}
