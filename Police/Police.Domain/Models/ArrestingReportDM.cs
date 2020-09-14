using System;
using System.Collections.Generic;
using System.Text;

namespace Police.Domain.Models
{
    public class ArrestingReportDM
    {
        private string _id;
        private string _arrestingOfficer;

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
        public string ArrestingOfficer 
        {
            get => _arrestingOfficer; 
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Badge number of arresting officer cannot be empty", nameof(value));
                }
                _arrestingOfficer = value;
            }
        }
        public DateTime ArrestDate { get; set; }
        public int CriminalID { get; set; }
        public int CrimeID { get; set; }

        public ArrestingReportDM(string reportID, string officer, DateTime arrestDate, int criminal, int crime)
        {
            ID = reportID;
            ArrestingOfficer = officer;
            ArrestDate = arrestDate;
            CriminalID = criminal;
            CrimeID = crime;
        }

        public ArrestingReportDM() { }
    }
}
