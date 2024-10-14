﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DALProject.Models
{
    public class  Driver : Employee
    {
        public string License  { get; set; }

        [Display(Name = "License Date")]
        public DateTime LicenseDate { get; set; }

        [Display(Name = "License Expiry Date")]
        public DateTime LicenseExpDate { get; set; }
    }
   

}
