using MySql.Data.MySqlClient;
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
	public partial class CustomerForm : Form
	{
        public bool modifyMode;
        public BindingList<City> Cities = new BindingList<City>();
        public Customer currentCustomer;
        public AppState MainState;

        public CustomerForm(AppState State, bool modifyMode = false, Customer currentCustomer = null)
		{
			InitializeComponent();
            loadCity();
            this.modifyMode = modifyMode;
            this.MainState = State;
            if (currentCustomer != null)
            {
                this.currentCustomer = currentCustomer;
            }
            if (modifyMode)
            {
                customerFormLabel.Text = "Modify Customers";
                //set form data from appointment passed in
                this.customerName.Text = currentCustomer.customerName;
                this.activeCustomer.Checked = currentCustomer.active == 1 ? true : false;
                this.inactiveCustomer.Checked = currentCustomer.active == 0 ? true : false;

                this.addressLine1.Text = currentCustomer.Address.address;
                this.addressLine2.Text = currentCustomer.Address.address2;
                this.city.SelectedItem = currentCustomer.Address.City;
                this.postalCode.Text = currentCustomer.Address.postalCode.ToString();
                this.phoneNumber.Text = currentCustomer.Address.phone;

            }
            else
            {
                customerFormLabel.Text = "Add Customers";
            }

        }

        public void loadCity()
        {
            //reset state
            Cities.Clear();
            //get all Cities
            string query = $"SELECT * FROM client_schedule.city;";
            MySqlConnection c = new MySqlConnection(AppState.connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    City city = new City(
                        cityId: rdr.GetInt32(0),
                        city: rdr.GetString(1),
                        countryId: rdr.GetInt32(2),
                        createDate: rdr.GetDateTime(3),
                        createdBy: rdr.GetString(4),
                        lastUpdate: rdr.GetDateTime(5),
                        lastUpdateBy: rdr.GetString(6)
                        );


                    Cities.Add(city);
                }
            }
            rdr.Close();
            c.Close();
            city.DataSource = Cities;
            city.DisplayMember = "city";
            city.ValueMember = "cityId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            /////// STARTS VALIDATION RULES
            ///
            if(customerName.Text.Length < 1) { MessageBox.Show("Customer Name Must Be Set"); return; }
            if(!activeCustomer.Checked && !inactiveCustomer.Checked) { MessageBox.Show("You must select either active or inactive customer"); return; }
            if (addressLine1.Text.Length < 1) { MessageBox.Show("You must set the Address Line 1"); return; }
            if(!(Cities.Contains(city.SelectedItem))) { MessageBox.Show("You must select a city from the dropdown"); return; }
            if (postalCode.Text.Length != 5) { MessageBox.Show("The postal code should be 5 digits"); return; }
            if (phoneNumber.Text.Length != 8) { MessageBox.Show("The phone number should be 7 digits in the form 000-0000"); return; }

            /////// ENDS VALIDATION RULES
            if (modifyMode)
            {
                //update customer props
                currentCustomer.customerName = customerName.Text;
                currentCustomer.active = activeCustomer.Checked ? 1 : 0;
                currentCustomer.lastUpdateBy = MainState.currentUserName;

               // check if address info changed, may have to create new address
                if(currentCustomer.Address.address != addressLine1.Text) { currentCustomer.addressId = (int)createNewAddress(); }
                if(currentCustomer.Address.address2 != addressLine2.Text) { currentCustomer.addressId = (int)createNewAddress(); }
                if(currentCustomer.Address.cityId != Convert.ToInt32(city.SelectedValue)) { currentCustomer.addressId = (int)createNewAddress(); }
                if (currentCustomer.Address.postalCode != Convert.ToInt32(postalCode.Text)) { currentCustomer.addressId = (int)createNewAddress(); }

                //check for just the phone number update
                if(currentCustomer.Address.phone != phoneNumber.Text)
                {
                    currentCustomer.Address.updatePhone(phoneNumber.Text);
                }


                MainState.updateCustomer(currentCustomer);

            }
            else
            {
                Customer customer = new Customer(
                    customerId: MainState.nextCustomerId(),
                    customerName: customerName.Text,
                    addressId: (int)createNewAddress(),
                    active: activeCustomer.Checked ? 1 : 0,
                    createDate: DateTime.Now.Date,
                    createdBy: MainState.currentUserName,
                    lastUpdateBy: MainState.currentUserName
                    );

                MainState.addCustomer(customer);
            }

            this.Close();
        }

        private Nullable<int> createNewAddress()
        {
            //add appointment to db and track in state
            string commandString =
                $"INSERT INTO `client_schedule`.`address`" +
                $" ( `address`," +
                $" `address2`, `cityId`," +
                $" `postalCode`, `phone`," +
                $" `createDate`, `createdBy`," +
                $" `lastUpdateBy`)" +
                $" VALUES" +
                $" ('{addressLine1.Text}'," +
                $" '{addressLine2.Text}', '{Convert.ToInt32(city.SelectedValue)}'," +
                $" '{postalCode.Text}', '{phoneNumber.Text}'," +
                $" '{DateTime.Now.Date.ToUniversalTime():yyyy-MM-dd HH:mm:ss}', '{MainState.currentUserName}'," +
                $" '{MainState.currentUserName}');";

            string queryString = $"SELECT addressId FROM client_schedule.address WHERE" +
                $" (address = '{addressLine1.Text}' AND address2 = '{addressLine2.Text}' AND postalCode = '{postalCode.Text}' AND phone='{phoneNumber.Text}' );";

            MySqlConnection c = new MySqlConnection(AppState.connectionString);
            c.Open();
            MySqlCommand Insertcmd = new MySqlCommand(commandString, c);
            Insertcmd.ExecuteNonQuery();

            int appointmentId;
            MySqlCommand cmd = new MySqlCommand(queryString, c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    appointmentId = rdr.GetInt32(0);
                    rdr.Close();
                    c.Close();
                    return appointmentId;
                }
            }
            rdr.Close();
            c.Close();
            return null;

        }
    }
}
