using System.ComponentModel.DataAnnotations;

namespace LCI.IDP.PasswordReset
{
    public class RequestPasswordViewModel
    {
        [Required]
        [MaxLength(200)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
