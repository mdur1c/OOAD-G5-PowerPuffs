using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Reviews
    {

        [Key] public int Id { get; set; }

        [ForeignKey("Student")] public string StudentUsername { get; set; }

        //[ForeignKey("Statistics")]
        public int StatisticsId { get; set; }

        public double Rate { get; set; }
        public string Comment { get; set; }

        // Navigation properties
        public virtual Statistics Statistics { get; set; }
        public virtual Student Student { get; set; }

        public Reviews() { }
    }
}
