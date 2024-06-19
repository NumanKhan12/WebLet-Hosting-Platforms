using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBLET.ViewModels
{
    public class RoleRegistrationViewModel
    {
        public string FULL_NAME { get; set; }
        public string EMAIL { get; set; }
        public DateTime  DOB { get; set; }
        public string PHONE { get; set; }
        public string ROLE { get; set; }
        public string CNIC { get; set; }
        public string PASSWORD { get; set; }
        public bool Payment_Approve { get; set; }

       
    }
}
