using System;
using System.ComponentModel.DataAnnotations;

namespace CrsTakipSistemi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; } // "Admin" veya "Staff"

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}
