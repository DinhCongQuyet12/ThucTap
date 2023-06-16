using System.ComponentModel.DataAnnotations;

namespace VerifyEmailForgotPassword.Models
{
    public class ResetPasswordRequest
    {
        [Required]
        public string Token { set; get; } = string.Empty;
        [Required,MinLength(6, ErrorMessage ="Please enter at ")]
        public string Password { set; get; } = string.Empty;
        [Required,Compare("Password")]
        public string ConfirmPassword { set; get; } = string.Empty;

    }
}
