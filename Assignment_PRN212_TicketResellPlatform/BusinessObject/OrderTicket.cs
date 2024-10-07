using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class OrderTicket
    {
        public bool? IsAccepted { get; set; }
        public string? Note { get; set; }
        public int Quantity { get; set; }
        public long? TotalPrice { get; set; }
        public long BuyerId { get; set; }
        public long GenericTicketId { get; set; }
        public long? PaymentMethodId { get; set; }

        public virtual User Buyer { get; set; } = null!;
        public virtual GenericTicket GenericTicket { get; set; } = null!;
        public virtual PaymentMethod? PaymentMethod { get; set; }
    }
}
