using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
    public class Model
    {
        public int Id { get; set; }
        

        [Display(Name = "Model Name")]
        public string ModelName { get; set; }

        [Display(Name = "Brand ID")]
        public int BrandId { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<Model> Models{ get; set; } = new HashSet<Model>();
        public virtual Brand Brand { get; set; }
        public virtual ICollection<Part> Parts { get; set; } = new HashSet<Part>();
    }
}
