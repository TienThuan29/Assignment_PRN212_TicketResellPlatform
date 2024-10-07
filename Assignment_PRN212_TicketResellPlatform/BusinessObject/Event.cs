using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class Event
    {
        public Event()
        {
            GenericTickets = new HashSet<GenericTicket>();
        }

        public int Id { get; set; }
        public string? Detail { get; set; }
        public DateTime EndDate { get; set; }
        public byte[]? Image { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }

        public virtual ICollection<GenericTicket> GenericTickets { get; set; }
    }
}
