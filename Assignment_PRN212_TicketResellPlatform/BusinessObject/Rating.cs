﻿using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class Rating
    {
        public string? Comment { get; set; }
        public short Stars { get; set; }
        public long BuyerId { get; set; }
        public long GenericTicketId { get; set; }

        public virtual User Buyer { get; set; } = null!;
        public virtual GenericTicket GenericTicket { get; set; } = null!;
    }
}
