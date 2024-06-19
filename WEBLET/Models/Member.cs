using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBLET.Models
{
    public class Member
    {
        public int MEMBER_ID { get; set; }
        public int MEMBER_PJ_CODE { get; set; }
        public string MEMBER_NAME { get; set; }
        public string MEMBER_TITLE { get; set; }
        public string MEMBER_FATHER_NAME { get; set; }
        public DateTime MEMBER_DOB { get; set; }
        public string MEMBER_CNIC { get; set; }
        public string MEMBER_COUNTRY { get; set; }
        public string MEMBER_CITY { get; set; }
        public string MEMBER_ADDRESS { get; set; }
        public string MEMBER_USERID { get; set; }
        public string MEMBER_PIC { get; set; }
        public string M_NUMBER { get; set; }
    }
}
