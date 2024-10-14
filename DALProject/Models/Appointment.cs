using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
    public class Appointment
    {
        public int Id { get; set; }


        [Display(Name = "Partial Report")]
        [Required]
        public string PartialReport { get; set; }
        [Display(Name = "Start Date & Time")]
        [Required]
        public DateTime StartDateTime { get; set; }
        [Display(Name = "End Date & Time")]
        [Required]
        public DateTime EndtDateTime { get; set; }
        public int TechnicalId { get; set; }
        public int DriverId { get; set; }

        [InverseProperty( nameof(Technical.Appointments))]
        public virtual Technical Technicians { get; set; }

        [InverseProperty( nameof(Driver.Appointments))]
        public virtual Driver Drivers { get; set; }
    }
}
