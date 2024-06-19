using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBLET.Models
{
    public class AspNetMesg
    {
        public Guid MSG_ID { get; set; }
        public string MSG { get; set; }
        public string FROM_USER { get; set; }
        public string TO_USER { get; set; }
        public DateTime MSG_DATETIME { get; set; }
        public string ISACTIVE { get; set; }
    

    }
}
