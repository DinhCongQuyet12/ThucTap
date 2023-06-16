using System.ComponentModel.DataAnnotations;

namespace VerifyEmailForgotPassword.Models
{
    public class UserLoginRequest
    {
        [Required, EmailAddress]
        public string Email { set; get; } = string.Empty;
        [Required]
        public string Password { set; get; } = string.Empty;
    }
}
