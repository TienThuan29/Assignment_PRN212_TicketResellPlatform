﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.DAO
{
    public class TransactionDAO
    {
        private SWP391_TicketResellPlatformContext dbContext;

        private static TransactionDAO instance;

        public static TransactionDAO Instance
        {
            get => instance = instance != null ? instance : new TransactionDAO();
        }

        private TransactionDAO()
        {
            this.dbContext = new SWP391_TicketResellPlatformContext();
        }

        // Your code below here

    }
}
