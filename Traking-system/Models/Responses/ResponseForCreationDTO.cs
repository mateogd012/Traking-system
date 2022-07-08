using System.ComponentModel.DataAnnotations;

namespace Traking_system.Models.Responses
{
    public class ResponseForCreationDTO
    {
        [Required]
        [MaxLength(2000)]
        public string Message { get; set; } = string.Empty;
    }
}
