using System.ComponentModel.DataAnnotations;

namespace Company_admin_system.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(80)]
        public string LastName { get; set; }

        [MaxLength(80)]
        public string Position { get; set; }

        public int salary { get; set; }

        public DateTime dayOfBirth { get; set; }
        
        [MaxLength(10)]
        public string phone { get; set; }

        public DateTime createdAt { get; set; } = DateTime.Now;
    }
}
