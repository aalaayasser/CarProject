using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
    public class Part
    {
        [Display(Name = "Part ID")]
        public int PartId { get; set; }

        [Required]
        [Display(Name = "Part Name")]
        public string PartName { get; set; }

        [Required(ErrorMessage = "Part Price is required.")]
        [Display(Name = "Part Price")]
        public int PartPrice { get; set; }

        [Required(ErrorMessage = "Part Kilometres to Change is required.")]
        [Display(Name = "Kilometres to Change Part")]
        public long PartKilometresToChange { get; set; }
        public virtual ICollection<Model> Models { get; set; } = new HashSet<Model>();
    }
}