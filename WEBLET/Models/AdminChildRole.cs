using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBLET.Models
{
    public class AdminChildRole
    {
        public Guid ID { get; set; }
        public string USER_ID { get; set; }
        public string TOKEN { get; set; }
        public string CONFIRMATION_TOKEN { get; set; }
    }
}
