using System;
using System.Collections.Generic;
using System.Text;

namespace Police.Domain.Models
{
    public class EvidenceDM
    {
        private string _name;
        private string _description;
        private string _caseNumber;

        public int ID { get; set; }
        public string Name 
        {
            get => _name;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Name cannot be empty", nameof(value));
                }
                _name = value;
            }
        }
        public string Description 
        {
            get => _description;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Description cannot be empty", nameof(value));
                }
                _description = value;
            }
        }
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

        public EvidenceDM(int id, string name, string description, string caseNumber)
        {
            ID = id;
            Name = name;
            Description = description;
            CaseNumber = caseNumber;
        }

        public EvidenceDM() { }
    }
}
