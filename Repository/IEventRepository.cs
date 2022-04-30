using CalendarManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarManagementApplication.Repository
{
    public interface IEventRepository
    {
        bool CreateEvent(SchedulerEvent model);
        bool UpdateEvent(int id);
        bool DeleteEvent(int id);
    }
}
