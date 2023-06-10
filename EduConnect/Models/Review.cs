using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Reviews
    {

        [Key] public string Id { get; set; }

        [ForeignKey("Student")] public string StudentUsername { get; set; }

        [ForeignKey("Statistics")] public string StatisticsId { get; set; }

        public double Rate { get; set; }
        public string Comment { get; set; }

        // Navigation properties
        public Statistics Statistics { get; set; }
        public Student Student { get; set; }

        public Reviews() { }
    }
}