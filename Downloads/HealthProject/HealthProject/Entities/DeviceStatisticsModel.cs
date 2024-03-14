using System;
using System.ComponentModel.DataAnnotations;

namespace HealthProject.Models
{
    public class DeviceStatistic
    {
        [Key]
        public int DeviceStatisticID { get; set; }

        public string Battery { get; set; }

        public string Firmware { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Datetime { get; set; }
        // public string Datetime { get; set; }

        public int UserDeviceID { get; set; }

        // Add other properties as needed
    }
}
