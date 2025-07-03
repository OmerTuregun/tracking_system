using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrsTakipSistemi.Models
{
    public class UserTask
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        [Required]
        public string Status { get; set; } // "ToDo", "InProgress", "Done"

        // Foreign Key
        [ForeignKey("User")]
        public int AssignedToUserId { get; set; }

        // Navigation Property
        public virtual User User { get; set; }
    }
}
