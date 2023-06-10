using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Enrolment
    {
        [Key] public string Id { get; set; }

        [ForeignKey("Student")]
        public string StudentUsername { get; set; }

        [ForeignKey("Course")]
        public string CourseId { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }

        public Enrolment() { }
    }
}