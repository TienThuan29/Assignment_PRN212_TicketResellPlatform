using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class ReportTypeDAO
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static ReportTypeDAO instance;

        public static ReportTypeDAO Instance
        {
            get => instance = instance != null? instance : new ReportTypeDAO(); 
        }

        private ReportTypeDAO()
        {
            this.dbContext = new SWP391_TicketResellPlatformContext();
        }

        // Your code below here

    }
}
