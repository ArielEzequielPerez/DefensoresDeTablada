using System.ComponentModel.DataAnnotations;

namespace defensoresCRUD.Models
{
    public class User : EntityBase
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,100}$", ErrorMessage = "Password must contain at least one lowercase letter, one uppercase letter, one digit and one special character.")]
        [Compare("PasswordConfirmation", ErrorMessage = "The password and confirmation password do not match.")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; } 
    }
}