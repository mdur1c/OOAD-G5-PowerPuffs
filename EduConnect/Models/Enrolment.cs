using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Enrolment
    {
        [Key] public int Id { get; set; }

        [ForeignKey("Student")]
        public string StudentUsername { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
              
        public Enrolment() { }
    }
}
