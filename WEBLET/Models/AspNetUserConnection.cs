using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBLET.Models
{
    public class AspNetUserConnection
    {
        public Guid ID { get; set; }
        public string CONNECTION_ID { get; set; }
        public string USER_ID { get; set; }
        public string IS_ONLINE { get; set; }
        public DateTime CON_DATETIME { get; set; }
        public string MSG_ISREADE { get; set; }
    }
}
