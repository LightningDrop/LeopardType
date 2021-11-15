using System.ComponentModel.DataAnnotations;

namespace LeopardType.Core.Models
{
    public class Passwords
    {
        [Key]
        public int PasswordId { get; set; }

        [Required]
        [MaxLength(15)]
        public string? Password { get; set; }
    }
}