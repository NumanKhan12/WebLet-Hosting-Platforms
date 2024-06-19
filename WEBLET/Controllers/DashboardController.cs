using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBLET.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult MemberDashbord()
        {
            return View("~/Views/Dashboard/MEMBER.cshtml");
        }
        public IActionResult CONSULTANT()
        {
            return View("~/Views/Dashboard/CONSULTANT.cshtml");
        }
    }
}
