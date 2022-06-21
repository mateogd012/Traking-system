using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traking_system.Entites
{
    public class Trips
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTrip { get; set; }
        [Required]
        [MaxLength(50)]
        public string Source { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Destination { get; set; } = string.Empty;


        public Trips(string source, string destination)
        {
            Source = source.Trim();
            Destination = destination.Trim();
        }

    }
}
