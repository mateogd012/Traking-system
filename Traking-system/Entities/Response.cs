using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traking_system.Entities
{
    public class Response
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime CreationDate { get; } = DateTime.Now;
        [ForeignKey("CreatorId")]
        public Username Creator { get; set; }
        public int CreatorId { get; set; }
        [ForeignKey("QuestionId")]
        public Trips Trip { get; set; }
        public int TripId { get; set; }

    }
}
