using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class TicketDAO
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static TicketDAO instance;  

        public static TicketDAO Instance
        {
            get => instance = instance != null ? instance : new TicketDAO();    
        }

        private TicketDAO() 
        {
            this.dbContext = new SWP391_TicketResellPlatformContext();  
        }

        // Your code below here

    }
}
