using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class PolicyDAO
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static PolicyDAO instance;

        public static PolicyDAO Instance
        {
            get => instance = instance != null ? instance : new PolicyDAO();
        }

        private PolicyDAO() 
        {
            this.dbContext = new SWP391_TicketResellPlatformContext();  
        }

        // Your code below here

    }
}
