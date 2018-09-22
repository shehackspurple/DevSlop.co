using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSlop.Slop.Data
{
    public class DbInitializer
    {
        public static void Initialize(DevSlopContext context, string connectionString)
        {
            //context.Database.Migrate();

            //CreateInitialAdminAccount(context, connectionString);
            //SeedTables(context, connectionString);
        }

        private static void SeedTables(DevSlopContext context, string connectionString)
        {

        }

        private static void CreateInitialAdminAccount(DevSlopContext context, string connectionString)
        {

        }
    }
}
