using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class Token
    {
        public long Id { get; set; }
        public bool? Expired { get; set; }
        public bool? Revoked { get; set; }
        public string Token1 { get; set; } = null!;
        public string? TokenType { get; set; }
        public long? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
