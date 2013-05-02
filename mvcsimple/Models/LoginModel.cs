using System.ComponentModel.DataAnnotations;

namespace MvcSimple.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Enter your username")]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter your password")]
        [DataType(DataType.Password)]        
        [Display(Name = "Password")]    
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

    }
}