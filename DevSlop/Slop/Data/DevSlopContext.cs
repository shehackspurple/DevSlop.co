using DevSlop.Slop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSlop.Slop.Data
{
    public class DevSlopContext : DbContext
    {
        public DevSlopContext(DbContextOptions<DevSlopContext> options)
            : base(options)
        {

        }

        
        public DbSet<Schedule> Schedules { get; set; }
    }
}
