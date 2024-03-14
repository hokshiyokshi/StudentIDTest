using System;
using System.ComponentModel.DataAnnotations;

namespace HealthProject.ViewModels
{
    public class CreateDeviceStatisticViewModel
    {
        [Required]
        [Display(Name = "Battery Level")]
        public string Battery { get; set; }

        [Required]
        [Display(Name = "Firmware Version")]
        public string Firmware { get; set; }

        [Required]
        [Display(Name = "Date and Time")]
        [DataType(DataType.DateTime)]
        public DateTime Datetime { get; set; }

        [Required]
        [Display(Name = "User Device ID")]
        public int UserDeviceID { get; set; }

        // You can add additional properties that might be required for the creation view
        // For example, if you need a list of users to select from:
        // public SelectList UserDevices { get; set; }
        // public int SelectedUserDeviceID { get; set; }
    }
}
