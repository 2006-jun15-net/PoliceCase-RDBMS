using System;
using System.Collections.Generic;
using System.Text;

namespace Police.Domain.Models
{
    public class PoliceReportDM
    {
        private string _id;
        private string _narrative;

        public string ID 
        {
            get => _id;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Police report ID cannot be empty", nameof(value));
                }
                _id = value;
            }
        }
        public DateTime TimeOccurred { get; set; }
        public DateTime TimeReported { get; set; }
        public string Narrative 
        {
            get => _narrative; 
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Narrative cannot be empty", nameof(value));
                }
                _narrative = value;
            }
        }
        public int CrimeID { get; set; }
        public int CrimeLocation { get; set; }

        public PoliceReportDM(string id, DateTime timeOccurred, DateTime timeReported, string narrative, int crime, int address)
        {
            ID = id;
            TimeOccurred = timeOccurred;
            TimeReported = timeReported;
            Narrative = narrative;
            CrimeID = crime;
            CrimeLocation = address;
        }

        public PoliceReportDM() { }
    }
}
