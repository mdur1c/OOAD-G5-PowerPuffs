using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Student: User
    {

        [ForeignKey("User")]
        public string UserId { get; set; }

        public Student() { }
    }
}
