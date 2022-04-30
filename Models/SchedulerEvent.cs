using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarManagementApplication.Models
{
    public class SchedulerEvent
    {
        public int EventID { get; set; }
        public string Description { get; set; }
        public int Start { get; set; }
        public int End { get; set; }

    }
}
