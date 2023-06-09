using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace EduConnect.Models
{
    public class User : IdentityUser
    {
        public string Loginname { get; set; } //username
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string CellPhoneNumber { get; set; }
        public string City { get; set; }
        public User() { }
    }
}
