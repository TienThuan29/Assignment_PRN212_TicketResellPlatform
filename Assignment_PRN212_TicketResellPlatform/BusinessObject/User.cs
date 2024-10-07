using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class User
    {
        public User()
        {
            GenericTickets = new HashSet<GenericTicket>();
            OrderTickets = new HashSet<OrderTicket>();
            Ratings = new HashSet<Rating>();
            ReportFrauds = new HashSet<ReportFraud>();
            Tokens = new HashSet<Token>();
            Transactions = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        public byte[]? Avatar { get; set; }
        public long? Balance { get; set; }
        public string CustomerCode { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Firstname { get; set; }
        public bool? IsEnable { get; set; }
        public bool? IsSeller { get; set; }
        public string? Lastname { get; set; }
        public string Password { get; set; } = null!;
        public string? Phone { get; set; }
        public long? Revenue { get; set; }
        public string? RoleCode { get; set; }
        public string? Username { get; set; }

        public virtual ICollection<GenericTicket> GenericTickets { get; set; }
        public virtual ICollection<OrderTicket> OrderTickets { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<ReportFraud> ReportFrauds { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
