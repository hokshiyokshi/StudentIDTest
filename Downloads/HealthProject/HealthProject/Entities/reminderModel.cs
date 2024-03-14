using System;
using System.ComponentModel.DataAnnotations;

namespace HealthProject.Models
{
    public class Reminder
    {
        [Key]
        public int ReminderID { get; set; }

        public int UserID { get; set; }

        public int DeviceID { get; set; }

        public string Status { get; set; }

        public string Notifications { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ReminderTime { get; set; }

        // Add other properties as needed
    }
}
