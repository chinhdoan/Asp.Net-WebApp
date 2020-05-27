using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evncpc.Models
{
    public class MenuModel
    {
        public int submenu_id { get; set; }
        public string sub_menu { get; set; }
        public string controller { get; set; }
        public string action { get; set; }
        public string mainmenu_name { get; set; }
        public int mainmenu_id { get; set; }
        public int? role_id { get; set; }
        public string role_name { get; set; }
    }
}