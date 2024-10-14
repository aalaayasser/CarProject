using System.Collections.Generic;

namespace DALProject.Models
{
    public class Technical : Employee
    {
        public virtual ICollection<Appointment> Appointments { get; set; } = new HashSet<Appointment>();
    }
}
