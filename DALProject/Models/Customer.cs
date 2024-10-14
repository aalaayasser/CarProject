using System.ComponentModel.DataAnnotations;

namespace DALProject.Models
{
    public class Customer : User
    {
        [Display(Name = "Preferred Communication")]
        public int PrefCommunication { get; set; }
    }
   

}
