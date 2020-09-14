using System;
using System.Collections.Generic;
using System.Text;

namespace Police.Domain.Models
{
    public class CrimeDM
    {
        private string _classification;

        public int CrimeID { get; set; }
        public string Classification 
        {
            get => _classification;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Classification cannot be empty", nameof(value));
                }
                _classification = value;
            }
        }

        public CrimeDM(int ID, string classification)
        {
            CrimeID = ID;
            Classification = classification;
        }

        public CrimeDM() { }
    }
}
