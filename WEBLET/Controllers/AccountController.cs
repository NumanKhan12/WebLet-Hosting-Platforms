using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using WEBLET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using WEBLET.BusinessLogics;
using WEBLET.ViewModels;
using WEBLET.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNet.Identity.Owin;

namespace WEBLET.Controllers
{
   // [Authorize]
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private ICompositeViewEngine _viewEngine;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ICompositeViewEngine viewEngine)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this._viewEngine = viewEngine;
        }
        public IActionResult UserRegistration()
        {
            return View("~/Views/Account/UserRegistrationView.cshtml");
        }


        //---==================================    ForgotPassword    --=============================================
        //=================================================================================================
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {  return Json(new Dictionary<string, string>
                {
                    {"Code","Failed" },{"Description","No Such User exists"}
                });
            }
            else
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var callback = Url.Action("ResetPassword", "Account", new { token = token, userId = user.Id }, Request.Scheme);
                var mail = new MailMessage();
                mail.From = new MailAddress("support@webletscript.com", "webletscript.com");
                mail.To.Add(email);
                mail.Subject = "Reset Password";
                mail.IsBodyHtml = true;
                mail.Body = "<h3>You can Reset Password Click on the link to Reset</h3> " +
                    $"<button onclick='window.location.href=" + callback + "'>Reset</button>" +
                    $"<a href='" + callback + "'>Reset</a>";
                using (var client = new SmtpClient("webletscript.com")) 
                {
                    client.Port = 25;
                    client.Credentials = new System.Net.NetworkCredential("support@webletscript.com", "0_Cbf7h3");
                    await client.SendMailAsync(mail);
                }
                return Json(new Dictionary<string, string>
                {
                    {"Code","Success" },{"Description","Done"}
                });
            }

        }
        //---==================================    UserRegistradtion    --=============================================
        //=================================================================================================
        [HttpPost]
        public async Task<IActionResult> UserRegistradtion(UserRegistrationViewModel vm)
        {

            ApplicationUser user = new ApplicationUser
            {
                Name=vm.FULL_NAME,
                cNIC=vm.CNIC,
                PhoneNumber=vm.MOBILE,
                Email=vm.EMAIL,
                dOB = Convert.ToDateTime("12-12-1900")
                ,UserName=vm.EMAIL,
                PJ_CODE=1,
                EmailConfirmed=false
            };
           
            //if (UserProcessor.CnicAlreayTaken(vm.CNIC))
            //{
            //    return Json(new Dictionary<string, string> {
            //        {"Code","Failed" } ,{"Description","CNIC is already taken" } });
            //}
            if (UserProcessor.PhoneAlreayTaken(vm.MOBILE))
            {
                return Json(new Dictionary<string, string> {
                    {"Code","Failed" } ,{"Description","Phone is already taken" } });
            }
            var result = await _userManager.CreateAsync(user, vm.Password);
            if (result.Succeeded)
            {
                await SendConfirmationEmail(vm.EMAIL);
                ApplicationUser GotUser = await _userManager.FindByEmailAsync(user.Email);
                await _userManager.AddToRoleAsync(GotUser, "Member");
                return Json(new Dictionary<string, string> {
                    {"Code","Success" } ,{"Description","Successfully Created ,Email confirmation link is sent " },{ "RedirectUrl","/Account/Login"} });
            }
            else
            {
                var error = "";
                var errorCode = "";
                foreach (var item in result.Errors)
                {
                    error = item.Description;
                    errorCode = item.Code;
                    break;
                }

                return Json(new Dictionary<string, string> {
                    {"Code",errorCode } ,{"Description",error } });
            }
        }
        //---==================================    ResetPassword    --=============================================
        //=================================================================================================
        [HttpGet]
        public async Task<IActionResult> ResetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel resetPasswordModel)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(resetPasswordModel.id);
            var resetPassResult = await _userManager.ResetPasswordAsync(user, resetPasswordModel.token, resetPasswordModel.password);
            if (!resetPassResult.Succeeded)
            {
                var error = "";
                var errorCode = "";
                foreach (var item in resetPassResult.Errors)
                {
                    error = item.Description;
                    errorCode = item.Code;
                    break;
                }
                return Json(new Dictionary<string, string> {
                    {"Code",errorCode } ,{"Description",error } });
            }
            return Json(new Dictionary<string, string> {
                        { "Code","Success"},
                        {"RedirectUrl","/Account/Login" }
                    });
        }
        //---==================================    Login    --=============================================
        //=================================================================================================
        public async Task<IActionResult> Login()
        {
            if (_signInManager.IsSignedIn(User))
            {
                
                ApplicationUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user.EmailConfirmed == false)
                {
                    return View("~/Views/Account/Login.cshtml");
                }
                if (user!=null)
                {
                    if (await _userManager.IsInRoleAsync(user, "Admin"))
                    {
                        
                        return RedirectToAction("RoleRegistration", "RoleCreateAccount");
                    }
                    if (await _userManager.IsInRoleAsync(user, "Member"))
                    {
                        
                            return RedirectToAction("MemberDashbord", "Dashboard");
                        

                    }
                    if (await _userManager.IsInRoleAsync(user, "CONSULTANT"))
                    {
                        return RedirectToAction("CONSULTANT", "Dashboard");
                    }
                }
                
            }
            return View("~/Views/Account/Login.cshtml");
        }

        //---==================================    Login    --=============================================
        //=================================================================================================
        [HttpPost]
        public async Task<JsonResult> Login(LoginViewModel vm)
        {
             
             var    result = await _signInManager.PasswordSignInAsync(vm.email, vm.password, true,true);
            ApplicationUser user = await _userManager.FindByEmailAsync(vm.email);

            
            //await _userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                

                try
                {

                    //Response.Cookies.Append("PJ_CODE", "1");
                    //await _signInManager.SignInAsync(user, new AuthenticationProperties
                    //{
                    //    ExpiresUtc = DateTime.UtcNow.AddDays(1),
                    //    IsPersistent=true
                    //});
                }
                catch (Exception ex)
                {
                    throw;
                }
                if (await _userManager.IsInRoleAsync(user,"Admin"))
                {
                    return Json(new Dictionary<string, string> {
                        { "Code","Success"},
                        {"RedirectUrl","/RoleCreateAccount/RoleRegistration" }
                    });
                }
               
              
                if (await _userManager.IsInRoleAsync(user, "CONSULTANT"))
                {
                    return Json(new Dictionary<string, string> {
                        { "Code","Success"},
                        {"RedirectUrl","/Dashboard/CONSULTANT" }
                    });
                }
                if (await _userManager.IsInRoleAsync(user,"Member"))
                {
                    //Member member = MemberProcessor.GetMember(user.Id);
                    //if (member==null)
                    //{
                    //    return Json(new Dictionary<string, string> {
                    //    { "Code","Success"},
                    //    {"RedirectUrl","/Member/CompeleteRegistration" } });
                    //}
                    //else
                    //{
                        return Json(new Dictionary<string, string> {
                        { "Code","Success"},
                        {"RedirectUrl","/Dashboard/MemberDashbord" }
                    });
                  //  }
                    
                }
                if (await _userManager.IsInRoleAsync(user, "Vendor"))
                {
                    return Json(new Dictionary<string, string> {
                        { "Code","Success"},
                        {"RedirectUrl","/Booking/ViewBookings" }
                    });
                }
                else
                {
                   return Json(new Dictionary<string, string> {
                        { "Code","Success"},
                        {"RedirectUrl","/Dashboard/Customer" }
                    });
                }
            }
            else
            {

                if(user==null)
                {
                    return Json(new Dictionary<string, string> {
                        { "Code","Failed"},
                        { "Description","Invalid Login"}
                    });

                }
               
                if (user.EmailConfirmed == false)
                {
                    await SendConfirmationEmail(vm.email);
                    return Json(new Dictionary<string, string> {
                        { "Code","Failed"},
                        {"Description","Email is not confirmed. Resend email" }
                    });
                }


                return Json(new Dictionary<string, string> {
                        { "Code","Failed"},
                        { "Description","Invalid Login"}
                    });
            }
        }
        //---==================================    ChangePassword    --=============================================
        //=================================================================================================

        [HttpGet]
        public async Task<IActionResult> ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> ChangePassword(string password, string newpassword)
        {
            var user = await _userManager.GetUserAsync(User);
            var result = await _userManager.ChangePasswordAsync(user, password, newpassword);
            if (!result.Succeeded)
            {
                var data = new Dictionary<string, string>();
                foreach (var item in result.Errors)
                {
                    data.Add("Code", item.Code);
                    data.Add("Description", item.Description);
                    break;
                }
                return Json(data);
            }
            else
            {
                return Json(new Dictionary<string, string> { { "Code", "Success" } });
            }
        }
        //---==================================    LogOut    --=============================================
        //=================================================================================================
        public async Task<IActionResult> LogOut()
        {
            if (_signInManager.IsSignedIn(User))
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Login");
            }
            return RedirectToAction("LogIn");
        }
        //---==================================    RegisterAdmin    --=============================================
        //=================================================================================================
        public async Task<string> RegisterAdmin(RegisterViewModel vm)
        {
            var user = new ApplicationUser()
            {
                UserName = vm.email,
                Email = vm.email,
                dOB = Convert.ToDateTime("12-12-1900")
            };
            var result = await _userManager.CreateAsync(user, vm.password);
            await SendConfirmationEmail(vm.email);
            if (result.Succeeded)
            {
                await SendConfirmationEmail(vm.email);
                ApplicationUser GotUser = await _userManager.FindByEmailAsync(user.Email);
                await _userManager.AddToRoleAsync(GotUser, "Admin");
                return "Success";
            }
            else
            {
                var error = "";
                foreach (var item in result.Errors)
                {
                    error = item.Description;
                }
                return error;
            }
        }
        //---==================================    RegisterVendor    --=============================================
        //=================================================================================================
        public async Task<string> RegisterVendor(VendorViewModel vm)
        {
            var user = new ApplicationUser()
            {
                Name = vm.Name,
                UserName = vm.email,
                Email = vm.email,
                dOB = Convert.ToDateTime("12-12-1900"),
                PhoneNumber = vm.Phone,
                cNIC = vm.CNIC,
                EmailConfirmed = false
                ,PJ_CODE=1
               

            };
            var result = await _userManager.CreateAsync(user, vm.password);
            await SendConfirmationEmail(vm.email);
            if (result.Succeeded)
            {
                await SendConfirmationEmail(vm.email);
                ApplicationUser GotUser = await _userManager.FindByEmailAsync(user.Email);
                await _userManager.AddToRoleAsync(GotUser, "Vendor");
                return "Success";
            }
            else
            {
                var error = "";
                foreach (var item in result.Errors)
                {
                    error = item.Description;
                }
                return error;
            }
        }

        //---==================================    RoleRegister    --=============================================
        //=================================================================================================
        public async Task<IActionResult> RoleRegister(RoleRegistrationViewModel vm)
        {
            ApplicationUser user = new ApplicationUser
            {
                Name = vm.FULL_NAME,
                cNIC = vm.CNIC,
                PhoneNumber = vm.PHONE,
                Email = vm.EMAIL,
                dOB = Convert.ToDateTime("12-12-1900")
          ,
                UserName = vm.EMAIL,
                PJ_CODE = 1,
                EmailConfirmed = false
            };

            //if (UserProcessor.CnicAlreayTaken(vm.CNIC))
            //{
            //    return Json(new Dictionary<string, string>
            //    {
            //        {"Code","Failed" },{"Description","CNIC is already taken" }
            //    });

            //}
            if (UserProcessor.PhoneAlreayTaken(vm.PHONE))
            {
                return Json(new Dictionary<string, string> {
                   {"Code","Failed" },{"Description","Pnone is already taken" }
                });

            }
            
            var result = await _userManager.CreateAsync(user, vm.PASSWORD);
          
            if (result.Succeeded)
            {
                await SendConfirmationEmail(vm.EMAIL);
                ApplicationUser GotUser = await _userManager.FindByEmailAsync(user.Email);
                await _userManager.AddToRoleAsync(GotUser, vm.ROLE);
                if (vm.Payment_Approve)
                {
                    string token = Guid.NewGuid().ToString();
                    string firstEncreption = CryptoEngine.Encrypt(token, GotUser.Id.Substring(0, 16));
                    string SecondEncreption = CryptoEngine.Encrypt(token, GotUser.Id.Substring(7, 16));
                    AdminChildRole approvel = new AdminChildRole();

                    approvel.USER_ID = GotUser.Id;
                    approvel.TOKEN = firstEncreption;
                    approvel.CONFIRMATION_TOKEN = SecondEncreption;

                    AdminChildRoleProccess.InsertRightRole(approvel);
                    // await _userManager.DeleteAsync(GotUser);

                }
                return Json(
                    "Success");
            }
            else
            {
                var error = "";
                var errorCode = "";
                foreach (var item in result.Errors)
                {
                    error = item.Description;
                    errorCode = item.Code;
                    break;
                }

                return Json(error);

            }
        }

        //---==================================    SendHelpEmail    --=============================================
        //=================================================================================================
        [HttpPost]
        public async Task<JsonResult> SendHelpEmail(Supportdata support)
        {
            var mail = new MailMessage();
            mail.From = new MailAddress("support@webletscript.com", "webletscript.com");

            mail.To.Add("support@webletscript.com");
            mail.Subject = "Support Email";
            mail.IsBodyHtml = true;
            mail.Body = $"<h2><b>Hello Laban</b></h2><br/><p> This Email is From :<b>{support.Email} </b><br/> And his name is :<b>{support.Name}</b><br/> Subject of" +
                $"this Email is <b>:{support.Subject}</b><br/> and the Full length message is <br/>:<b>{support.Msg}.</b> <p>";
            using (var client = new SmtpClient("webletscript.com"))
            {
                client.Port = 25;
                client.Credentials = new System.Net.NetworkCredential("support@webletscript.com", "0_Cbf7h3");
                await client.SendMailAsync(mail);
            }
            return Json(new Dictionary<string, string>
            {
                {"Code","Success" },
                {
                    "Value","1"}
            });
        }
        //---==================================    SendConfirmationEmail    --=============================================
        //=================================================================================================
        [HttpPost]
        public async Task SendConfirmationEmail(string email)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(email);
            string confirmationToken = await _userManager.
                          GenerateEmailConfirmationTokenAsync(user);
            string confirmationLink = Url.Action("ConfirmEmail",
                            "Account", new
                            {
                                email = email,
                                token = confirmationToken
                            },
                                Request.Scheme);
            //protocol: HttpContext.
            var mail = new MailMessage();
            mail.From = new MailAddress("support@webletscript.com", "webletscript.com");
            mail.To.Add(email);
            mail.Subject = "Confirmation Email";
            mail.IsBodyHtml = true;
            mail.Body = $"<h2><b>Welcome User</b></h2><br/> this is Confirmation Link <br/> {confirmationLink}";
            using (var client = new SmtpClient("webletscript.com"))
            {
                client.Port = 25;
                client.Credentials = new System.Net.NetworkCredential("support@webletscript.com", "0_Cbf7h3");
                await client.SendMailAsync(mail);
            }
        }
        //---==================================    ConfirmEmail    --=============================================
        //=================================================================================================
        public async Task<IActionResult> ConfirmEmail(string email, string token)
        {
            var User = await _userManager.FindByEmailAsync(email);
            IdentityResult result = _userManager.ConfirmEmailAsync(User, token).Result;
            if (result.Succeeded)
            {
                
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return View();
            }

        }

    }

}