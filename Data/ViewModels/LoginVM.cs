using System.ComponentModel.DataAnnotations;

namespace eTickets.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address Is required")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password Is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
