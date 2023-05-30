using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Appointment
    {
        [Key] public int Id { get; set; }

        [ForeignKey("Tutor")] public string TutorUsername { get; set; }
        [ForeignKey("Student")] public string StudentUsername { get; set; }
        //[ForeignKey("Bill")] public int BillId { get; set; }

        public double Price { get; set; }
        public string Time { get; set; }
        public string Day { get; set; }
        public int BillId { get; set; }

        // Navigation properties
        public virtual Tutor Tutor { get; set; }
        public virtual Student Student { get; set; }
        public virtual Bill Bill { get; set; }

        public Appointment() { }
    }
}
