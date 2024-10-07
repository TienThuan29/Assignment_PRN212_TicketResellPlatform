using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class StaffToken
    {
        public long Id { get; set; }
        public bool? Expired { get; set; }
        public bool? Revoked { get; set; }
        public string Token { get; set; } = null!;
        public string? TokenType { get; set; }
        public long? StaffId { get; set; }

        public virtual Staff? Staff { get; set; }
    }
}
