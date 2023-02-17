using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingService.Models
{
    public class City
    {
        public int cityId { get; set; }
        public string city { get; set; }
        public int countryId { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }
        public Country Country;

        public City(
            int cityId,
            string city,
            int countryId,
            DateTime createDate,
            string createdBy,
            DateTime lastUpdate,
            string lastUpdateBy
            )
        {
            this.cityId = cityId;
            this.city = city;
            this.countryId = countryId;
            this.createDate = createDate;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdateBy = lastUpdateBy;

            getCountryById(countryId);
        }

        public Country getCountryById(int countryId)
        {
            string query = $"SELECT * FROM client_schedule.country WHERE countryId = '{countryId}';";
            MySqlConnection c = new MySqlConnection(AppState.connectionString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                if (rdr.Read())
                {
                    Country country = new Country(
                         countryId: rdr.GetInt32(0),
                         country: rdr.GetString(1),
                         createDate: rdr.GetDateTime(2),
                         createdBy: rdr.GetString(3),
                         lastUpdate: rdr.GetDateTime(4),
                         lastUpdateBy: rdr.GetString(5)
                         );
                    rdr.Close();
                    c.Close();
                    return country;
                }
            }

            //no result
            return null;
        }
    }
}
