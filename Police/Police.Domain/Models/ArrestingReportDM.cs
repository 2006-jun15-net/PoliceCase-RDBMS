using System;
using System.Collections.Generic;
using System.Text;

namespace Police.Domain.Models
{
    public class ArrestingReportDM
    {
        public string ReportID { get; set; }
        public string ArrestingOfficer { get; set; }
        public DateTime ArrestDate { get; set; }
        public int CriminalID { get; set; }
        public int CrimeID { get; set; }
    }
}
