using System;
using System.IO;

namespace SchedulingService.Models
{
    public class AuthState
    {
        public static string connectionString = "server=localhost;user=root;database=client_schedule;port=3306;password=Passw0rd!";
        public int currentUserId { get; set; }

        public static void writeUserLog(int userId)
        {
            string fileName = "log.txt";
            string timeStamp = Util.createTimestamp();
            string appendText = $"User ID: {userId} -> logged in at {timeStamp}" + Environment.NewLine;
            // Create a file to write to.
            using (StreamWriter writer = new StreamWriter(Path.Combine(Environment.CurrentDirectory, fileName), true))
            {
                writer.WriteLine(appendText);
            }
        }
        public int getCurrentUserId()
        {
            return currentUserId;
        }

        public void setCurrentUserId(int currentUserId)
        {
            this.currentUserId = currentUserId;
        }
    }

}
