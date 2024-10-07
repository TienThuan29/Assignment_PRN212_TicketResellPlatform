using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class GenericTicket
    {
        public GenericTicket()
        {
            OrderTickets = new HashSet<OrderTicket>();
            Ratings = new HashSet<Rating>();
            Tickets = new HashSet<Ticket>();
        }

        public long Id { get; set; }
        public string? Area { get; set; }
        public string? Description { get; set; }
        public DateTime ExpiredDateTime { get; set; }
        public bool? IsPaper { get; set; }
        public string? LinkEvent { get; set; }
        public long Price { get; set; }
        public double? SalePercent { get; set; }
        public string? TicketName { get; set; }
        public int? CategoryId { get; set; }
        public int? EventId { get; set; }
        public int? PolicyId { get; set; }
        public long? SellerId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Event? Event { get; set; }
        public virtual Policy? Policy { get; set; }
        public virtual User? Seller { get; set; }
        public virtual ICollection<OrderTicket> OrderTickets { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
