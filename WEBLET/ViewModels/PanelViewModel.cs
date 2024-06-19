using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBLET.ViewModels
{
    public class PanelViewModel
    {
     

        public string ID { get; set; }
        public string PANEL_ID { get; set; }

        public string DISCRIPTION { get; set; }
        public string CONDITION { get; set; }
        public string DELEVERYDAY { get; set; }
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
        public string PRICE { get; set; }
        public string SHIPMRNT { get; set; }
        public string DEMO_LINK { get; set; }
        public string RETURNS_DIS { get; set; }
    }
}
