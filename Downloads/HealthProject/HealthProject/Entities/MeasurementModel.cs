using System;
using System.ComponentModel.DataAnnotations;

namespace HealthProject.Models
{
    public class Measurement
    {
        [Key]
        public int MeasurementID { get; set; }

        public int AttributeID { get; set; }

        public string MeasurementValue { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Datetime { get; set; }

        public int UserDeviceID { get; set; }

        // Add other properties as needed
    }
}
