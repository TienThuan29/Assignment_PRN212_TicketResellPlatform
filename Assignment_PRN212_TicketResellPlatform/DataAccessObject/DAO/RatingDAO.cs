using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class RatingDAO
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static RatingDAO instance;

        public static RatingDAO Instance 
        {
            get => instance = instance !=  null ? instance : new RatingDAO();
        }

        private RatingDAO() 
        { 
            this.dbContext = new SWP391_TicketResellPlatformContext();
        }

        // Your code below here


    }
}
