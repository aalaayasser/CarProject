using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Display(Name = "Model ID")]
        [Required]
        public int ModelId { get; set; }

        [Display(Name = "Customer ID")]
        [Required]
        public int CustomerId { get; set; }

        [Display(Name = "Color ID")]
        public long ColorId { get; set; }
        [Required]

        [Display(Name = "Kilometres")]
        public long KiloMetres { get; set; }

        [Display(Name = "Year of Manufacture")]
        public DateTime Year { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<Ticket>? Tickets { get; set; } = new HashSet<Ticket>();

        public virtual Customer Customer { get; set; }
        public virtual Color Color { get; set; }
        public virtual Model Model { get; set; }

    }
}
