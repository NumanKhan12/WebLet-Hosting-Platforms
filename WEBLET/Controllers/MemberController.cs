using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WEBLET.BusinessLogics;
using WEBLET.Data;
using WEBLET.Models;
using WEBLET.ViewModels;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Hosting;

namespace WEBLET.Controllers
{
    class BOK
    {
        public int BOK_ID { get; set; }
    }
    //[Route("Member")]
    [Authorize]
    public class MemberController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private readonly IHostingEnvironment hostingEnvironment;
        public MemberController(IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            this.hostingEnvironment = hostingEnvironment;
            _signInManager = signInManager;
        }
        // [Route("Create")]
        public IActionResult CompeleteRegistration()
        {
            return View("~/Views/Member/CompeleteRegistration.cshtml");
        }
       
        public async Task<IActionResult> Create(string data)
        {
            Member member = JsonConvert.DeserializeObject<Member>(data);
            ApplicationUser user = await _userManager.GetUserAsync(User);
            member.MEMBER_PJ_CODE = Session.GetCpCode(User.Identity.Name);
            member.MEMBER_USERID = _userManager.GetUserId(User);
            member.MEMBER_CNIC = user.cNIC.ToString();
            user.Name = member.MEMBER_NAME;
            var result = await _userManager.UpdateAsync(user);
            string uniquefilename = null;
            if (Request.Form.Files.Count > 0)
            {
                string UploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniquefilename = Guid.NewGuid().ToString() + "_" + Request.Form.Files[0].FileName;
                string filepath = Path.Combine(UploadsFolder, uniquefilename);
                Request.Form.Files[0].CopyTo(new FileStream(filepath, FileMode.Create));
                member.MEMBER_PIC = uniquefilename;
            }
            int res = MemberProcessor.SaveMEMBER(member);
            if (res == 1)
            {
                return Json("Success");
            }
            else
            {
                return Json("Failed");
            }
        }
        [HttpGet]
        public async Task<IActionResult> EditMember()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EditMember(string data)
        {
            Member member = JsonConvert.DeserializeObject<Member>(data);
            ApplicationUser user = await _userManager.GetUserAsync(User);
            user.Name = member.MEMBER_NAME;
            user.PhoneNumber = member.M_NUMBER;
            var result = await _userManager.UpdateAsync(user);
            Member existingMember = MemberProcessor.GetMember(user.Id);
            member.MEMBER_PJ_CODE = Session.GetCpCode(User.Identity.Name);
            member.MEMBER_USERID = _userManager.GetUserId(User);
            member.MEMBER_CNIC = user.cNIC.ToString();
            member.MEMBER_ID = existingMember.MEMBER_ID;
            string uniquefilename = null;
            if (Request.Form.Files.Count > 0)
            {
                string UploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniquefilename = Guid.NewGuid().ToString() + "_" + Request.Form.Files[0].FileName;
                string filepath = Path.Combine(UploadsFolder, uniquefilename);
                Request.Form.Files[0].CopyTo(new FileStream(filepath, FileMode.Create));
                member.MEMBER_PIC = uniquefilename;
            }
            else
            {
                member.MEMBER_PIC = existingMember.MEMBER_PIC;
            }
            int res = MemberProcessor.Update(member);
            if (res == 1)
            {
                return Json("Success");
            }
            else
            {
                return Json("Failed");
            }
        }


        public IActionResult MemberRegistrationView()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> LoadMembers()
        {
            List<Member> Mem = MemberProcessor.GetMembers(Session.GetCpCode(User.Identity.Name));
            return PartialView("~/Views/Member/Member.cshtml", Mem);
        }
        //[HttpGet]
        //public async Task<IActionResult> GetMember(string CNIC, int BOK_ID)
        //{
        //    Member Mem = MemberProcessor.GetMemberByCNIC(CNIC);
        //    if (Mem == null)
        //    {
        //        return PartialView("~/Views/Member/MemberSearchPartial.cshtml", BOK_ID);
        //    }
        //    BookingProcessor.AddMemberToBooking(Mem.MEMBER_ID, BOK_ID);
        //    BOOKING_VIEW_MODEL bOOKING = BookingProcessor.GetBOOKING_Details(BOK_ID);
        //    return PartialView("~/Views/Member/MemberDetailsPartial.cshtml", bOOKING);
        //}
        [HttpPost]
        public async Task<string> CreateMember(string data)
        {
            MemberRegistrationViewModel vm = JsonConvert.DeserializeObject<MemberRegistrationViewModel>(data);
            ApplicationUser user = new ApplicationUser
            {
                Name = vm.MEMBER_NAME,
                cNIC = vm.MEMBER_CNIC,
                PhoneNumber = vm.M_NUMBER,
                Email = vm.EMAIL,
                PasswordHash = vm.PASSWORD,

                dOB = Convert.ToDateTime("12-12-1900"),
                EmailConfirmed = true
                ,
                UserName = vm.EMAIL
            };
            if (UserProcessor.CnicAlreayTaken(vm.MEMBER_CNIC))
            {
                return "CNIC is already taken";
            }
            if (UserProcessor.PhoneAlreayTaken(vm.M_NUMBER))
            {
                return "Phone is already taken";
            }
            var result = await _userManager.CreateAsync(user, vm.PASSWORD);
            if (result.Succeeded)
            {
                ApplicationUser GotUser = await _userManager.FindByEmailAsync(user.Email);
                await _userManager.AddToRoleAsync(GotUser, "Member");
                int res = MemberProcessor.SaveMEMBER(new Member
                {
                    MEMBER_NAME = vm.MEMBER_NAME,
                    MEMBER_TITLE = vm.MEMBER_TITLE,
                    MEMBER_FATHER_NAME = vm.MEMBER_FATHER_NAME,
                    MEMBER_COUNTRY = vm.MEMBER_COUNTRY,
                    MEMBER_ADDRESS = vm.MEMBER_ADDRESS,
                    MEMBER_USERID = GotUser.Id,
                    MEMBER_CITY = vm.MEMBER_CITY,
                    MEMBER_CNIC = vm.MEMBER_CNIC,
                    MEMBER_DOB = vm.MEMBER_DOB,
                    MEMBER_PIC = vm.MEMBER_PIC,


                });
                return "Success";
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
                return error;
            }
        }
        [HttpPost]
        public async Task<JsonResult> UpdatePic(string data)
        {
            BOK bOK = JsonConvert.DeserializeObject<BOK>(data);
            string uniquefilename = null;
            //BOOKING_VIEW_MODEL bvm = BookingProcessor.GetBOOKING_Details(bOK.BOK_ID);
            if (Request.Form.Files.Count > 0)
            {
                string UploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniquefilename = Guid.NewGuid().ToString() + "_" + Request.Form.Files[0].FileName;
                string filepath = Path.Combine(UploadsFolder, uniquefilename);
                Request.Form.Files[0].CopyTo(new FileStream(filepath, FileMode.Create));
                //await UpdateMemberPic(Request.Form.Files[0].FileName, Request.Form.Files[0], bvm.MEMBER_CNIC);
            }
            return Json(new Dictionary<string, string> {
                    {"Code","Success" },
                    {"value",bOK.BOK_ID.ToString()
                }, }
               );
        }
        public async Task UpdateMemberPic(string filename, IFormFile file, string CNIC)
        {
            string uniquefilename;
            uniquefilename = GuidProcessor.SaveFile(Path.Combine(hostingEnvironment.WebRootPath, "images"), filename, file);
            Member member = MemberProcessor.GetMemberByCNIC(CNIC);
            if (member.MEMBER_PIC != null)
            {
                string _imageToBeDeleted = Path.Combine(hostingEnvironment.WebRootPath, "images", member.MEMBER_PIC);
                if ((System.IO.File.Exists(_imageToBeDeleted)))
                {
                    try
                    {
                        System.IO.File.Delete(_imageToBeDeleted);
                    }
                    catch (Exception ex)
                    {
                        member.MEMBER_PIC = uniquefilename;
                        int r = MemberProcessor.Update(member);
                    }
                }
            }
            member.MEMBER_PIC = uniquefilename;
            int res = MemberProcessor.Update(member);
        }
    }
}