using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Tutor: User
    {
        // Navigation property
        public Statistics Statistics { get; set; }

        public Tutor() { }
    }
}