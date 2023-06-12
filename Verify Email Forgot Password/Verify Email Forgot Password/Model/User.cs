namespace VerifyEmailForgotPassword.Model
{
    public class User
    {
        public int Id { set; get; }
        public string Email { set; get; } = string.Empty;
        public byte[] PasswordHash { set; get; } = new byte[32];
        public byte[] PasswordSalt { set; get; }
        public string? VerificationToken { set; get; }
        public string? PasswordResetToken { set; get; }
        public DateTime? ResetTokenExpires { set; get; }



    }
}
