using System.ComponentModel.DataAnnotations;

namespace MusicStore_blazor.Models
{
    public class UserForLoginDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
