using System;
using System.Collections.Generic;
using System.Text;

namespace Police.Domain.Models
{
    public class CaseFolderDM
    {
        private string _caseNumber;
        private string _detective;
        private string _policeReportID;
        private string _arrestingReportID;

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
        public bool Active { get; set; }
        public string Detective 
        {
            get => _detective;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Detective cannot be empty", nameof(value));
                }
                _detective = value;
            }
        }
        public string PoliceReportID 
        {
            get => _policeReportID; 
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Police Report ID cannot be empty", nameof(value));
                }
                _policeReportID = value;
            }
        }
        public string ArrestingReportID 
        {
            get => _arrestingReportID;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Arresting Report ID cannot be empty", nameof(value));
                }
                _arrestingReportID = value;
            }
        }

        public CaseFolderDM(string caseNumber, bool active, string detective, string policeReportID, string arrestingReportID)
        {
            CaseNumber = caseNumber;
            Active = active;
            Detective = detective;
            PoliceReportID = policeReportID;
            ArrestingReportID = arrestingReportID;
        }

        public CaseFolderDM() { }
    }
}
