using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace SchedulingService
{
    static class Util
    {
        public static string createTimestamp()
        {
            return DateTime.Now.ToString("u");
        }

        public static IEnumerable<DateTime> Daily(this TimeSpan ts, DayOfWeek startDayOfWeek = DayOfWeek.Sunday, DateTime? checkDay = null)
        {
            var compDate = checkDay ?? DateTime.UtcNow;
            var days = startDayOfWeek - compDate.DayOfWeek;
            days = days > 0 ? days - 7 : days;
            var startDate = compDate.AddDays(days);

            for (var i = 0; i < 7; i++)
            {
                yield return startDate.AddDays(i).Date + ts;
            }
        }

    }

}