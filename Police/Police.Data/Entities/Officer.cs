using System;
using System.Collections.Generic;

namespace Police.Data.Entities
{
    public partial class Officer
    {
        public Officer()
        {
            ArrestingReport = new HashSet<ArrestingReport>();
            AutopsyReport = new HashSet<AutopsyReport>();
            CaseFolder = new HashSet<CaseFolder>();
        }

        public string BadgeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Rank { get; set; }
        public byte[] Portrait { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<ArrestingReport> ArrestingReport { get; set; }
        public virtual ICollection<AutopsyReport> AutopsyReport { get; set; }
        public virtual ICollection<CaseFolder> CaseFolder { get; set; }
    }
}
