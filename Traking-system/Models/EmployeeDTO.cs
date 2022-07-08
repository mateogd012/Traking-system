namespace Traking_system.Models
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public IList<TripsDTO> TripsAttended { get; set; } = new List<TripsDTO>();
    }
}
