using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class TypePolicy
    {
        public TypePolicy()
        {
            Policies = new HashSet<Policy>();
        }

        public long Id { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Policy> Policies { get; set; }
    }
}
