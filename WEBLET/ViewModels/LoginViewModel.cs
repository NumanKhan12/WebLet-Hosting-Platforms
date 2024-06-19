	using System.ComponentModel.DataAnnotations;

namespace WEBLET.ViewModels
{
    public class LoginViewModel
    {
        [Required,EmailAddress,Display(Name ="Email Address")]
        public string email { get; set; }
        [Required,DataType(DataType.Password),Display(Name ="Password")]
        public string password { get; set; }
        [Display(Name ="Remember Me")]
        public bool rememberMe { get; set; }
    }
}
