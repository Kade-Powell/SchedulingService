using System;
using System.IO;

namespace SchedulingService.Models
{
    public class AuthState
    {
        public static string connectionString = "server=localhost;user=root;database=client_schedule;port=3306;password=Passw0rd!";
        public int currentUserId { get; set; }

        public static void writeUserLog(string userName, bool success)
        {
            string fileName = "log.txt";
            string timeStamp = Util.createTimestamp();
            string appendText;
            if (success)
            {
                appendText = $"SUCCESS: User: {userName} -> logged in at {timeStamp}" + Environment.NewLine;
            }
            else //fail auth
            {
                appendText = $"AUTH FAILURE: User: {userName} -> failed to log in at {timeStamp}" + Environment.NewLine;
            }
            
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
