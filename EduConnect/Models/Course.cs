using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Course
    {
        [Key] public string Id { get; set; }

        [ForeignKey("Tutor")] public string TutorUsername { get; set; }

        public string Subject { get; set; }
        public string Level { get; set; }
        public int Price { get; set; }

        // Navigation properties
        public Tutor Tutor { get; set; }

        public Course() { }
    }
}