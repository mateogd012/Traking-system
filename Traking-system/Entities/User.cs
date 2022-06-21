using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traking_system.Entites
{
    public abstract class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUser { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Password { get; set; } = string.Empty;

    }
}
