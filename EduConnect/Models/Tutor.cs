using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Tutor : User
    {
        //[ForeignKey("Statistics")]
        public int StatisticsId { get; set; }

        // Navigation property
        public virtual Statistics Statistics { get; set; }

        public Tutor() { }
    }
}
