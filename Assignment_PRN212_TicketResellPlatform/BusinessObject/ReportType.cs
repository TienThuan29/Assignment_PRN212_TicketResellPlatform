using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class ReportType
    {
        public ReportType()
        {
            ReportFrauds = new HashSet<ReportFraud>();
        }

        public int Id { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<ReportFraud> ReportFrauds { get; set; }
    }
}
