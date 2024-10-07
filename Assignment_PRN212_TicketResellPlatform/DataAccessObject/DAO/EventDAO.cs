using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// *Note: Must not modify singleton
namespace DataAccessObject.DAO
{
    public class EventDAO
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static EventDAO instance;

        public static EventDAO Instance 
        {
            get => instance = instance != null ? instance : new EventDAO();
        }

        private EventDAO()
        {
            this.dbContext = new SWP391_TicketResellPlatformContext();
        }

        // Your code below here

    }
}
