using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
    public class Color
    {
        [Required(ErrorMessage = "Color ID is required.")]
        [Display(Name = "Color ID")]
        public int ColorId { get; set; }
        [Display(Name = "Color")]
        [StringLength(50, ErrorMessage = "The Color Name must not exceed 50 characters.")]
        public string ColorName { get; set; }

        public virtual ICollection<Car> Car { get; set; } = new HashSet<Car>();

    }
}
