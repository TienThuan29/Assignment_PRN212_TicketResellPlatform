using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class HashtagEventDAO
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static HashtagEventDAO instance;

        public static HashtagEventDAO Instance
        {
            get => instance = instance != null ? instance : new HashtagEventDAO();

        }

        private HashtagEventDAO()
        {
            this.dbContext = new SWP391_TicketResellPlatformContext();
        }

        // Your code below here


    }
}
