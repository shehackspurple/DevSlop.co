using DevSlop.Slop.Data;
using DevSlop.Slop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSlop.Slop.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private DevSlopContext _context;

        public ScheduleRepository(DevSlopContext context)
        {
            _context = context;
        }

        public IEnumerable<Schedule> GetAllSchedules()
        {
            return _context.Schedules.ToList();
        }
    }
}
