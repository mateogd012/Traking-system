using Traking_system.Entites;

namespace Traking_system.Models.Responses
{
    public class ResponseDTO
    {
        public int Id { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; }
        public User Creator { get; set; }
    }
}
