using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_Web_App.Models
{
    public class Table2
    {
        public int Tab2_ID { get; set; }
        public int Room_temp_Heat { get; set; }
        public bool AC_status_heat { get; set; }
        public bool Window_status_heat { get; set; }
        public bool Blinds_status_heat { get; set; }
        public bool Fan_status_heat { get; set; }
    }
}