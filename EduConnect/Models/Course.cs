using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Course
    {
        [Key] public int Id { get; set; }

        [ForeignKey("Tutor")] public string TutorUsername { get; set; }

        public string Subject { get; set; }
        public string Level { get; set; }

        // Navigation properties
        public virtual Tutor Tutor { get; set; }

        public Course() { }
    }
}
