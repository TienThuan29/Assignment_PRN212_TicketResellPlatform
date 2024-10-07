using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class UserDAO
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static UserDAO instance;

        public static UserDAO Instance
        {
            get => instance = instance != null ? instance : new UserDAO();
        }

        private UserDAO()
        {
            this.dbContext = new SWP391_TicketResellPlatformContext();
        }

        // Your code below here

    }
}
