using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingService.Models
{
    public class Address
    {
        public int addressId { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public int cityId { get; set; }
        public int postalCode { get; set; }
        public string phone { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        public City City;

        public Address(
            int addressId,
            string address,
            string address2,
            int cityId,
            int postalCode,
            string phone,
            DateTime createDate,
            string createdBy,
            DateTime lastUpdate,
            string lastUpdateBy
            )
        {
            this.addressId = addressId;
            this.address = address;
            this.address2 = address2;
            this.cityId = cityId;
            this.postalCode = postalCode;
            this.phone = phone;
            this.createDate = createDate;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdateBy = lastUpdateBy;

            this.City = getCityById(cityId);
        }

        public City getCityById(int cityId)
        {
            string query = $"SELECT * FROM client_schedule.city WHERE cityId = '{cityId}';";
            MySqlConnection c = new MySqlConnection(AppState.connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                if (rdr.Read())
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
                    rdr.Close();
                    c.Close();
                    return city;
                }
            }

            //no result
            return null;

        }

        public void updatePhone(string phoneNumber)
        {
            string commandString =
                $"UPDATE `client_schedule`.`address`" +
                $" SET " +
                $" `phone` = '{phoneNumber}'" +
                $" WHERE `addressId` = '{addressId}';";

            MySqlConnection c = new MySqlConnection(AppState.connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(commandString, c);
            cmd.ExecuteNonQuery();
            c.Close();

            //keep state up to date with DB
            this.phone = phoneNumber;
        }
    }
}
