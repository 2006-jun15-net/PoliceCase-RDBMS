using System;
using System.Collections.Generic;

namespace Police.Data.Entities
{
    public partial class CaseFolder
    {
        public CaseFolder()
        {
            AutopsyReport = new HashSet<AutopsyReport>();
            Evidence = new HashSet<Evidence>();
        }

        public string CaseNumber { get; set; }
        public bool Active { get; set; }
        public string Detective { get; set; }
        public string PoliceReportId { get; set; }
        public string ArrestingReportId { get; set; }

        public virtual ArrestingReport ArrestingReport { get; set; }
        public virtual Officer DetectiveNavigation { get; set; }
        public virtual PoliceReport PoliceReport { get; set; }
        public virtual ICollection<AutopsyReport> AutopsyReport { get; set; }
        public virtual ICollection<Evidence> Evidence { get; set; }
    }
}
