using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Current Kilometres")]
        public int CurrentKilometres { get; set; }

        [Display(Name = "Start Date & Time")]
        public DateTime StartDateTime { get; set; }

        [Required]
        public string Location { get; set; }


        public string State { get; set; }

        [Display(Name = "Final Report")]
        public string FinalReport { get; set; }

        [Display(Name = "End Date & Time")]
        public DateTime EndDateTime { get; set; }

        [Display(Name = "Active Date of Part")]
        public DateTime ActiveDatePfPart { get; set; }


        public string Feedback { get; set; }

        [Display(Name = "Is Paid")]
        public char IsPayed { get; set; }

    }

}

