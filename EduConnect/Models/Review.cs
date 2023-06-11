using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Reviews
    {

        [Key] public string Id { get; set; }

        [ForeignKey("Student")] public string StudentUsername { get; set; }
        [ForeignKey("Tutor")] public string TutorId { get; set; }

        public double Rate { get; set; }
        public string Comment { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Tutor Tutor { get; set; }

        public Reviews() { }
    }
}