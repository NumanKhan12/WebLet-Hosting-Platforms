using System;
using System.ComponentModel.DataAnnotations;

namespace WEBLET.ViewModels
{
	public class RegisterViewModel
	{
		[Required, EmailAddress, MaxLength(256), Display(Name = "Email Address")]
		public String email { get; set; }
		[Required, MinLength(6), MaxLength(50), DataType(DataType.Password), Display(Name = "Password")]
		public String password { get; set; }
		[Compare("password", ErrorMessage = "the password does not match the Confirm Password"), DataType(DataType.Password)]
		[Display(Name = "Confirm Password")]
		public String confirmPassword { get; set; }
		//[Required,Display(Name ="Role")]
		//public String userRole { get; set; }
	}
}
