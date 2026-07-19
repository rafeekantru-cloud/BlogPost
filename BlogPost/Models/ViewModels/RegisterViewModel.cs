using System.ComponentModel.DataAnnotations;

namespace BlogPost.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage = "Email not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage = "Password must match the confirm password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
