using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingService.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public int addressId { get; set; }
        public int active { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime? lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }
        public Address Address;

        public Customer(
            int customerId,
            string customerName,
            int addressId,
            int active,
            DateTime createDate,
            string createdBy,
            string lastUpdateBy,
            DateTime? lastUpdate = null
            )
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.addressId = addressId;
            this.active = active;
            this.createDate = createDate;
            this.createdBy = createdBy;
            if(lastUpdate != null)
            {
                this.lastUpdate = lastUpdate;
            }
            this.lastUpdateBy = lastUpdateBy;

            this.Address = getAddressById(addressId);
        }

        public Address  getAddressById(int addressId)
        {
            string query = $"SELECT * FROM client_schedule.address WHERE addressId = '{addressId}';";
            MySqlConnection c = new MySqlConnection(AppState.connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                   Address address = new Address(
                        addressId: rdr.GetInt32(0),
                        address: rdr.GetString(1),
                        address2: rdr.GetString(2),
                        cityId: rdr.GetInt32(3),
                        postalCode: rdr.GetInt32(4),
                        phone: rdr.GetString(5),
                        createDate: rdr.GetDateTime(6),
                        createdBy: rdr.GetString(7),
                        lastUpdate: rdr.GetDateTime(8),
                        lastUpdateBy: rdr.GetString(9)
                        );
                    rdr.Close();
                    c.Close();
                    return address;
                }
            }
            
            //no result
            return null;

        }
    }
}
