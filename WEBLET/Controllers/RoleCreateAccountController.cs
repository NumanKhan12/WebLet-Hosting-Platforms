using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBLET.Controllers
{
    public class RoleCreateAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult RoleRegistration()
        {
            return View("~/Views/RoleCreateAccount/RoleRegistration.cshtml");
        }
    }
}
