using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class PaymentMethodDAO
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static PaymentMethodDAO instance;

        public static PaymentMethodDAO Instance
        {
            get => instance = instance != null ? instance : new PaymentMethodDAO(); 
        }

        private PaymentMethodDAO() 
        {
            this.dbContext = new SWP391_TicketResellPlatformContext();
        }

        // Your code below here

    }
}
