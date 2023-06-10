using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Student: User
    {
        public int Year { get; set; }

        public Student() { }
    }
}