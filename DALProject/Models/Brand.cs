﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }

        public virtual ICollection<Model> Models { get; set; } = new HashSet<Model>();
    }
}

