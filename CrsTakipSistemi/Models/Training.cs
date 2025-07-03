using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrsTakipSistemi.Models
{
    public class Training
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        // Foreign Key
        [ForeignKey("User")]
        public int UserId { get; set; }

        // Navigation Property
        public virtual User User { get; set; }
    }
}
