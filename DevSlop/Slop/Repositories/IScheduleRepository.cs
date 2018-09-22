using DevSlop.Slop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSlop.Slop.Repositories
{
    public interface IScheduleRepository
    {
        IEnumerable<Schedule> GetAllSchedules();
    }
}
