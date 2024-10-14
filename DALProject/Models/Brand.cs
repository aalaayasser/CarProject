using System;
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

        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime UpdatedDate { get; set; }
    }

}
