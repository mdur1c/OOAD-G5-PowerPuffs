using System.ComponentModel.DataAnnotations;

namespace EduConnect.Models
{
    public class Tutor
    {
        [Key] public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
        public string CV { get; set; }
        public Tutor() { }
    }
}