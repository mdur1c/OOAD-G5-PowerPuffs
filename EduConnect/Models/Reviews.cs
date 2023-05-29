using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class Reviews
    {

        [Key] public int Id { get; set; }
        public double Rate { get; set; }
        public string Comment { get; set; }
        [ForeignKey("Student")] public string StudentUsername { get; set; }

        public Reviews() { }
    }
}
