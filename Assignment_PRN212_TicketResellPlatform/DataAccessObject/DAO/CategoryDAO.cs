using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// *Note: Must not modify singleton
namespace DataAccessObject.DAO
{
    public class CategoryDAO
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get => instance = instance != null ? instance : new CategoryDAO();
        }

        private CategoryDAO()
        {
            this.dbContext = new SWP391_TicketResellPlatformContext();
        }

        // Your code below here

    }
}
