using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class Category
    {
        public Category()
        {
            GenericTickets = new HashSet<GenericTicket>();
        }

        public int Id { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<GenericTicket> GenericTickets { get; set; }
    }
}
