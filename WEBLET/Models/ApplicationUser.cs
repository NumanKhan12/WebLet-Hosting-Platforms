using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.Extensions.Options;

namespace WEBLET.Models
{
    public class  ApplicationUser:IdentityUser  
    {
        //public string userRole { get; set; }
        public DateTime dOB { get; set; }
        //public String email { get; set; }
        public string address { get; set; }
        public string cNIC { get; set; }
        //navigation
        public string Name { get; set; }

        //cpCode
        public int PJ_CODE { get; set; }

    }
}
