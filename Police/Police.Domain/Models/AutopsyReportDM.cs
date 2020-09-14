using System;
using System.Collections.Generic;
using System.Text;

namespace Police.Domain.Models
{
    public class AutopsyReportDM
    {
        private string _id;
        private string _mannerOfDeath;
        private string _causeOfDeath;
        private string _examiner;
        private string _caseNumber;

        public string ID 
        {
            get => _id;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Report ID cannot be empty", nameof(value));
                }
                _id = value;
            }
        }
        public string MannerOfDeath 
        {
            get => _mannerOfDeath;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Manner of Death cannot be empty", nameof(value));
                }
                _mannerOfDeath = value;
            }
        }
        public string CauseOfDeath 
        {
            get => _causeOfDeath;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Cause of Death cannot be empty", nameof(value));
                }
                _causeOfDeath = value;
            }
        }
        public string Examiner 
        {
            get => _examiner; 
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Examiner cannot be empty", nameof(value));
                }
                _examiner = value;
            }
        }
        public DateTime DateExamined { get; set; }
        public int VictimID { get; set; }
        public string CaseNumber 
        {
            get => _caseNumber; 
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Case Number cannot be empty", nameof(value));
                }
                _caseNumber = value;
            }
        }

        public AutopsyReportDM(string report, string mannerOfDeath, string causeOfDeath, string examiner, DateTime date, int victim, string caseNumber)
        {
            ID = report;
            MannerOfDeath = mannerOfDeath;
            CauseOfDeath = causeOfDeath;
            Examiner = examiner;
            DateExamined = date;
            VictimID = victim;
            CaseNumber = caseNumber;
        }

        public AutopsyReportDM() { }
    }
}
