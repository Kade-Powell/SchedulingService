using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace SchedulingService.Models
{
    class User
    {
        public MySqlConnection Conn { get; set; }
        public int userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int active { get; set; }
        public MySqlDateTime createDate { get; set; }
        public string createdBy { get; set; }
        public User()
        {
            string connStr = "server=localhost;user=root;database=client_schedule;port=3306;password=Passw0rd!";
            Conn = new MySqlConnection(connStr);
        }
    }
}
