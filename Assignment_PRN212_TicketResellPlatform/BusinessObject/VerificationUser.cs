using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class VerificationUser
    {
        public long UserId { get; set; }
        public long? StartTime { get; set; }
        public string? VerifiactionCode { get; set; }
        public string? VerificationType { get; set; }
    }
}
