using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class StaffDAO
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get => instance = instance != null ? instance : new StaffDAO(); 
        }

        private StaffDAO() 
        { 
            this.dbContext = new SWP391_TicketResellPlatformContext();
        }

        // Your code below here 

    }
}
