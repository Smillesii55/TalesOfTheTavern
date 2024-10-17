using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Wachtwoord")]
        [MinLength(6, ErrorMessage = "Het wachtwoord moet minimaal 6 tekens lang zijn.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bevestig wachtwoord")]
        [Compare("Password", ErrorMessage = "Het wachtwoord en de bevestiging komen niet overeen.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Rol")]
        public string Role { get; set; } // Voeg dit toe
    }
}
