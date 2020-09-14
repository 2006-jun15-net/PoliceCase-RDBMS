using System;
using System.Collections.Generic;
using System.Text;

namespace Police.Domain.Models
{
    public class InvolvedPersonsDM
    {
        private string _caseNumber;

        public int WitnessID { get; set; }
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

        public InvolvedPersonsDM(int witness, string caseNumber)
        {
            WitnessID = witness;
            CaseNumber = caseNumber;
        }

        public InvolvedPersonsDM() { }
    }
}
