using System.ComponentModel.DataAnnotations;

namespace Passion.Areas.Admin.ViewModels
{
    public class Signup
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm Password Not Match Password")]
        public string ConfirmPassword { get; set; }
    }
}
