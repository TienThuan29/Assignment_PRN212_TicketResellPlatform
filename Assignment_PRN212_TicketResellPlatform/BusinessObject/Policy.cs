using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class Policy
    {
        public Policy()
        {
            GenericTickets = new HashSet<GenericTicket>();
        }

        public int Id { get; set; }
        public string? Content { get; set; }
        public int Fee { get; set; }
        public bool? IsDeleted { get; set; }
        public long? TypePolicyId { get; set; }

        public virtual TypePolicy? TypePolicy { get; set; }
        public virtual ICollection<GenericTicket> GenericTickets { get; set; }
    }
}
