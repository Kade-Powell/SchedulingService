using MySql.Data.MySqlClient;
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
    public partial class NewCustomersThisMonthForm : Form
    {
        public List<Models.Customer> NewCustomersThisMonth = new List<Models.Customer>();
        public NewCustomersThisMonthForm()
        {
            InitializeComponent();
            getNewCustomersByMonth(DateTime.Now.Month);
            newCustomerListView.DataSource = NewCustomersThisMonth;


        }

        private void getNewCustomersByMonth(int Month)
        {
                string query = $"SELECT * FROM client_schedule.customer WHERE MONTH(createDate) = {Month};";
                MySqlConnection c = new MySqlConnection("server=localhost;user=root;database=client_schedule;port=3306;password=Passw0rd!");
                c.Open();
                MySqlCommand cmd = new MySqlCommand(query, c);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                    NewCustomersThisMonth.Add(
                        new Models.Customer(
                            customerId: rdr.GetInt32(0),
                            customerName: rdr.GetString(1),
                            addressId: rdr.GetInt32(2),
                            active: rdr.GetInt32(3),
                            createDate: rdr.GetDateTime(4).ToLocalTime(),
                            createdBy: rdr.GetString(5),
                            lastUpdate: rdr.GetDateTime(6).ToLocalTime(),
                            lastUpdateBy: rdr.GetString(7)
                            )
                        );
                   
                    }
                }
                rdr.Close();
                c.Close();
            }
    }
}
