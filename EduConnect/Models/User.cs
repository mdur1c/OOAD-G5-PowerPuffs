using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace EduConnect.Models
{
    public class User : IdentityUser
    {
        [Key] override public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        override public string UserName { get; set; }
        override public string Email { get; set; }
        public string City { get; set; }

        public User() { }
    }
}