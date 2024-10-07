using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class HashtagDAO
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static HashtagDAO instance;

        public static HashtagDAO Instance 
        {
            get => instance = instance != null ? instance : new HashtagDAO();
        }

        private HashtagDAO()
        {
            dbContext = new SWP391_TicketResellPlatformContext();
        }

        // Your code below here

    }
}
