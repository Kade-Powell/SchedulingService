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
        public BindingList<Appointment> AllUsersAppointments = new BindingList<Appointment>();
        public BindingList<Appointment> Appointments = new BindingList<Appointment>();
        public BindingList<Appointment> WeeklyAppointments = new BindingList<Appointment>();
        public BindingList<Appointment> MonthlyAppointments = new BindingList<Appointment>();
        public BindingList<Customer> Customers { get; } = new BindingList<Customer>();
        public int currentUserId { get; set; }
        public string currentUserName { get; set; }
        public static string connectionString = "server=localhost;user=root;database=client_schedule;port=3306;password=Passw0rd!";

        public AppState(int UserId, string userName)
        {
            currentUserId = UserId;
            currentUserName = userName;
            loadUserAppointments();
            loadCustomers();
        }

        //methods
        public void loadUserAppointments()
        {
            //reset state
            AllUsersAppointments.Clear();
            //get all appointments for current user
            string query = $"SELECT * FROM client_schedule.appointment";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    AllUsersAppointments.Add(new Appointment(
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
            calculateUsersAppointments();
            calculateMonthly();
            calculateWeekly();
        }
        private void calculateUsersAppointments()
        {
            Appointments.Clear();
            foreach (var app in AllUsersAppointments)
            {
                if (app.userId == currentUserId)
                {
                    Appointments.Add(app);
                }
            }
        }
        private void calculateMonthly()
        {
            MonthlyAppointments.Clear();
            foreach (var app in Appointments)
            {
                if (app.start.Month == DateTime.Now.Month && app.start.Year == DateTime.Now.Year)
                {
                    MonthlyAppointments.Add(app);
                }
            }
        }
        private void calculateWeekly()
        {
            WeeklyAppointments.Clear();
            TimeSpan thisWeek = new TimeSpan(0, 0, 0, 0);
            IEnumerable<DateTime> currentWeek = Util.Daily(thisWeek);
            foreach (Appointment appointment in Appointments)
            {
                foreach (DateTime day in currentWeek)
                {
                    if (appointment.start.Date == day.Date)
                    {
                        WeeklyAppointments.Add(appointment);
                    }
                }
            }
        }
        public void loadCustomers()
        {
            //get all appointments for current user
            string query = $"SELECT * FROM client_schedule.customer";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                //reset state
                Customers.Clear();
                while (rdr.Read())
                {
                    Customers.Add(new Customer(
                            customerId: Convert.ToInt32(rdr.GetValue(0)),
                            customerName: rdr.GetValue(1).ToString(),
                            addressId: Convert.ToInt32(rdr.GetValue(2)),
                            active: Convert.ToInt32(rdr.GetValue(3)),
                            createDate: rdr.GetDateTime(4).ToLocalTime(),
                            createdBy: rdr.GetValue(5).ToString(),
                            lastUpdate: rdr.GetDateTime(6).ToLocalTime(),
                            lastUpdateBy: rdr.GetValue(7).ToString()

                        ));
                }

            }
            rdr.Close();
            c.Close();
        }
        public (bool, List<string>) checkForUrgentAppointments()
        {
            bool hasUrgentAppointment = false;
            List<string> messages = new List<string>();

            foreach (Appointment appointment in Appointments)
            {
                TimeSpan timeFromNow = appointment.start - DateTime.Now;
                if (timeFromNow.TotalMinutes < 15 && timeFromNow.TotalMinutes > -1)
                {
                    messages.Add($"Appointment ID: {appointment.appointmentId} with customer ID: {appointment.customerId} starting soon, at {appointment.start}");
                    hasUrgentAppointment = true;
                }
            }

            return (hasUrgentAppointment, messages);
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
        public int nextCustomerId()
        {
            int highestId = 0;
            foreach ( Customer customer in Customers)
            {
                if (customer.customerId > highestId)
                {
                    highestId = customer.customerId;
                }
            }
            //increment to make nextCustomerId
            highestId += 1;
            return highestId;
        }
        public int nextAppointmentId()
        {
            int highestId = 0;
            foreach (Appointment appointment in AllUsersAppointments)
            {
                if (appointment.appointmentId > highestId)
                {
                    highestId = appointment.appointmentId;
                }
            }
            //increment to make nextCustomerId
            highestId += 1;
            return highestId;
        }
        public void addAppointment(Appointment appointment)
        {
            //add appointment to db and track in state
            string commandString =
                $"INSERT INTO `client_schedule`.`appointment`" +
                $" (`appointmentId`, `customerId`," +
                $" `userId`, `title`," +
                $" `description`, `location`," +
                $" `contact`, `type`," +
                $" `url`, `start`," +
                $" `end`, `createDate`," +
                $" `createdBy`, `lastUpdateBy`)" +
                $" VALUES" +
                $" ('{appointment.appointmentId}', '{appointment.customerId}'," +
                $" '{appointment.userId}', '{appointment.title}'," +
                $" '{appointment.description}', '{appointment.location}'," +
                $" '{appointment.contact}', '{appointment.type}'," +
                $" '{appointment.url}', '{appointment.start.ToUniversalTime():yyyy-MM-dd HH:mm:ss}'," +
                $" '{appointment.end.ToUniversalTime():yyyy-MM-dd HH:mm:ss}', '{appointment.createDate.ToUniversalTime():yyyy-MM-dd HH:mm:ss}'," +
                $" '{appointment.createdBy}', '{appointment.lastUpdateBy}');";


            
                MySqlConnection c = new MySqlConnection(connectionString);
                c.Open();
                MySqlCommand cmd = new MySqlCommand(commandString, c);
                cmd.ExecuteNonQuery();
            c.Close();
            //keep db in sync with local state on success
            loadUserAppointments();
        }
        public void updateAppointment(Appointment appointment)
        {
            //add appointment to db and track in state
            string commandString =
                $"UPDATE `client_schedule`.`appointment`" +
                $" SET " +
                $" `customerId` = '{appointment.customerId}'," +
                $" `userId` = '{appointment.userId}'," +
                $" `title` = '{appointment.title}'," +
                $" `description` = '{appointment.description}'," +
                $" `location` = '{appointment.location}'," +
                $" `contact` = '{appointment.contact}'," +
                $" `type`= '{appointment.type}'," +
                $" `url` = '{appointment.url}'," +
                $" `start` = '{appointment.start.ToUniversalTime():yyyy-MM-dd HH:mm:ss}'," +
                $" `end` = '{appointment.end.ToUniversalTime():yyyy-MM-dd HH:mm:ss}'," +
                $" `lastUpdateBy` = '{appointment.lastUpdateBy}'" +
                $" WHERE `appointmentId` = '{appointment.appointmentId}';";

            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(commandString, c);
            cmd.ExecuteNonQuery();
            c.Close();
            //keep db in sync with local state on success
            loadUserAppointments();
        }
        public void deleteAppointment(Appointment appointment)
        {
            string commandString = $"DELETE FROM `client_schedule`.`appointment` WHERE `appointmentId` = '{appointment.appointmentId}';";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(commandString, c);
            int rowsAffected = cmd.ExecuteNonQuery();
            c.Close();
            //keep db in sync with local state on success
            loadUserAppointments();
        }
        public void addCustomer(Customer customer)
        {
            //add customer to db and track in state
            string commandString =
                $"INSERT INTO `client_schedule`.`customer`" +
                $" (`customerId`," +
                $" `customerName`, " +
                $" `addressId`," +
                $" `active`," +
                $" `createDate`," +
                $" `createdBy`," +
                $" `lastUpdateBy`)" +
                $" VALUES" +
                $" ('{customer.customerId}'," +
                $" '{customer.customerName}'," +
                $" '{customer.addressId}'," +
                $" '{customer.active}'," +
                $" '{customer.createDate.ToUniversalTime():yyyy-MM-dd HH:mm:ss}'," +
                $" '{customer.createdBy}', " +
                $" '{customer.lastUpdateBy}');";

            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(commandString, c);
            cmd.ExecuteNonQuery();
            c.Close();
            //keep db in sync with local state on success
            loadCustomers();
        }
        public void updateCustomer(Customer customer)
        {
            //add customer to db and track in state
            string commandString =
                $"UPDATE `client_schedule`.`customer`" +
                $" SET " +
                $" `customerName` = '{customer.customerName}', " +
                $" `addressId` = '{customer.addressId}'," +
                $" `active` = '{customer.active}'," +
                $" `lastUpdateBy` = '{customer.lastUpdateBy}'" +
                $" WHERE `customerId` = '{customer.customerId}';";

            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(commandString, c);
            cmd.ExecuteNonQuery();
            c.Close();
            //keep db in sync with local state on success
            loadCustomers();
        }
        public void deleteCustomer(Customer customer)
        {
            string commandString = $"DELETE FROM `client_schedule`.`customer` WHERE `customerId` = '{customer.customerId}';";
            MySqlConnection c = new MySqlConnection(connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(commandString, c);
            int rowsAffected = cmd.ExecuteNonQuery();
            c.Close();
            //keep db in sync with local state on success
            loadCustomers();
        }




    }


}
