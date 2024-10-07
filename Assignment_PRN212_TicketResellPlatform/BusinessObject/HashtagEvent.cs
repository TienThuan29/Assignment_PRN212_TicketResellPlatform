using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class HashtagEvent
    {
        public int HashtagId { get; set; }
        public int EventId { get; set; }

        public virtual Event Event { get; set; } = null!;
        public virtual Hashtag Hashtag { get; set; } = null!;
    }
}
