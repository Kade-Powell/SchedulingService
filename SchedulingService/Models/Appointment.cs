

using System;

namespace SchedulingService.Models
{
    public class Appointment
    {
        public int appointmentId { get; set; }
        public int customerId { get; set; }
        public int userId { get; set; }
        public string  title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string contact { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public MySql.Data.Types.MySqlDateTime start { get; set; }
        public MySql.Data.Types.MySqlDateTime end { get; set; }
        public MySql.Data.Types.MySqlDateTime createDate { get; set; }
        public string createBy { get; set; }
        public MySql.Data.Types.MySqlDateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        public Appointment(
            int appointmentId,
            int customerId,
            int userId,
            string title,
            string description,
            string location,
            string contact,
            string type,
            string url,
            MySql.Data.Types.MySqlDateTime start,
            MySql.Data.Types.MySqlDateTime end,
            MySql.Data.Types.MySqlDateTime createDate,
            string createBy,
            MySql.Data.Types.MySqlDateTime lastUpdate,
            string lastUpdateBy
            )
        {
            this.appointmentId = appointmentId;
            this.customerId = customerId;
            this.userId = userId;
            this.title = title;
            this.description = description;
            this.location = location;
            this.contact = contact;
            this.type = type;
            this.url = url;
            this.start = start;
            this.end = end;
            this.createDate = createDate;
            this.createBy = createBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdateBy = lastUpdateBy;
        }
    }

    
}
