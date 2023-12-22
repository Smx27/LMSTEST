using System.ComponentModel.DataAnnotations;

namespace LMS.DTO
{
	public class RegisterDTO
	{
        [Required]
        public string Username { get; set; }
        [Required]
        [MinLength(4)]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
    }
}
