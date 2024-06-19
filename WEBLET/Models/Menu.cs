using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBLET.Models
{
    public class Menu
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string viewName { get; set; }
        public string ControllerName { get; set; }
        public string icon { get; set; }
        public bool isDelete { get; set; }
        public int? parentID { get; set; }
        public List<Menu> Menus { get; set; }
    }
}
