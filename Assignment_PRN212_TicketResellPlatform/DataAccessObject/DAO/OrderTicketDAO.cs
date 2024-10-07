using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class OrderTicketDAO
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static OrderTicketDAO instance;

        public static OrderTicketDAO Instance;
        {
            get => instance = instance != null ? instance : new OrderTicketDAO();   
        }

        private OrderTicketDAO() 
        {
            dbContext = new SWP391_TicketResellPlatformContext();
        }

        // Your code below here

    }
}
