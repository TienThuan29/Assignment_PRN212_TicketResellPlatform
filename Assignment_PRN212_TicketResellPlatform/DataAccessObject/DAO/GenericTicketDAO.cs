using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class GenericTicketDAO
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static GenericTicketDAO instance;

        public static GenericTicketDAO Instance 
        {
            get => instance = instance != null? instance : new GenericTicketDAO();
        }

        private GenericTicketDAO() 
        {
            this.dbContext = new SWP391_TicketResellPlatformContext();
        }

        // Your code below here
    }
}
