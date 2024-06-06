using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModels;

public class AddUserViewModel
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(15, MinimumLength = 5, 
        ErrorMessage = "Name must be between 5 and 15 characters")]
    public string? Username { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be betwen 6 and 20 characters")]
    public string? Password { get; set; }

     [Required(ErrorMessage = "Verification of password is required.")]
    public string? VerifyPassword { get; set; }
}
