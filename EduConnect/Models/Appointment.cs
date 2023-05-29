using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Appointment
    {
        [Key] public int Id { get; set; }
        public double Price { get; set; }
        public string Time { get; set; }
        public string Day { get; set; }
        public int BillId { get; set; }
        [ForeignKey("Tutor")] public string TutorUsername { get; set; }
        [ForeignKey("Student")] public string StudentUsername { get; set; }

        public Appointment() { }
    }
}
