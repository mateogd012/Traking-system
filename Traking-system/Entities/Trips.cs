using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traking_system.Entites
{
    public class Trips
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Source { get; set; }

        [MaxLength(50)]
        public string Destination { get; set; }
        [MaxLength(50)]
        public string TripOwner { get; set; }

        public Trips(string source, string destination, string tripowner)
        {
            Source = source;
            Destination = destination;
            TripOwner = tripowner;
        }  
        

    }
}
