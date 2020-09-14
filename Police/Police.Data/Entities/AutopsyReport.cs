using System;
using System.Collections.Generic;

namespace Police.Data.Entities
{
    public partial class AutopsyReport
    {
        public string ReportId { get; set; }
        public string MannerOfDeath { get; set; }
        public string CauseOfDeath { get; set; }
        public string Examiner { get; set; }
        public DateTime DateExamined { get; set; }
        public int VictimId { get; set; }
        public string CaseNumber { get; set; }

        public virtual CaseFolder CaseNumberNavigation { get; set; }
        public virtual Officer ExaminerNavigation { get; set; }
        public virtual Victim Victim { get; set; }
    }
}
