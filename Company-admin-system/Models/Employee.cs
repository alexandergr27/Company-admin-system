using System.ComponentModel.DataAnnotations;

namespace Company_admin_system.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        public string lastName { get; set; }

        public DateTime dayOfBirth { get; set; }

        public string phone { get; set; }

        public DateTime createdAt { get; set; } = DateTime.Now;
    }
}
