namespace Traking_system.Models
{
    public class TripsDTO
    {
        public int Id { get; set; }
        public string Source { get; set; }

        public string Destination { get; set; }
        public ICollection<TrukerDTO> Trukers { get; set; } = new List<TrukerDTO>();

    }
}
