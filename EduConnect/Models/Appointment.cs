using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Appointment
    {
        [Key] public string Id { get; set; }

        [ForeignKey("Tutor")] public string TutorUsername { get; set; }
        [ForeignKey("Student")] public string StudentUsername { get; set; }

        public double Price { get; set; }
        public string Time { get; set; }
        public string Day { get; set; }

        // Navigation properties
        public Tutor Tutor { get; set; }
        public Student Student { get; set; }
        public Bill Bill { get; set; }

        public Appointment() { }
    }
}