using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class ReportFraud
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static ReportFraud instance;    

        public static ReportFraud Instance
        {
            get =>  instance != null ? instance : new ReportFraud();
        }

        private ReportFraud() 
        {
            this.dbContext = new SWP391_TicketResellPlatformContext();
        }

        // Your code below here


    }
}
