using System.ComponentModel.DataAnnotations;

namespace VerifyEmailForgotPassword.Model
{
    public class UserRegisterRequest
    {
        [Required, EmailAddress]
        public string Email { set; get; } = string.Empty;
        [Required, MinLength(6)]
        public string Password { set; get; } = string.Empty;
        [Required,Compare("Password")]
        public string ConfirmPassword { set; get; } = string.Empty;

    }
}
