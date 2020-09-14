using System;
using System.Collections.Generic;
using System.Text;

namespace Police.Domain.Models
{
    public class OfficerDM
    {
        private string _badgeNumber;
        private string _firstName;
        private string _lastName;
        private string _rank;

        public string BadgeNumber 
        {
            get => _badgeNumber;
            set
            {
                if (value.Length != 3)
                {
                    throw new ArgumentException("Badge Number must be 3 digits long", nameof(value));
                }
                foreach (char c in value)
                {
                    if (c < '0' || c > '9')
                    {
                        throw new ArgumentException("Badge Number must only contain digits", nameof(value));
                    }
                }
                _badgeNumber = value;
            }
        }
        public string FirstName 
        {
            get => _firstName; 
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name cannot be empty", nameof(value));
                }
                _firstName = value;
            }
        }
        public string LastName 
        {
            get => _lastName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Last Name cannot be empty", nameof(value));
                }
                _lastName = value;
            }
        }
        public string Rank 
        {
            get => _rank;
            set
            {
                if (value != "Chief" && value != "Detective" && value != "Examiner" && value != "Street Cop")
                {
                    throw new ArgumentException("Rank must be either Chief, Detective, Examiner, or Street Cop", nameof(value));
                }
                _rank = value;
            }
        }
        public byte[] Portrait { get; set; }
        public int Address { get; set; }

        public OfficerDM(string badgeNumber, string firstName, string lastName, string rank, byte[] image, int address)
        {
            BadgeNumber = badgeNumber;
            FirstName = firstName;
            LastName = lastName;
            Rank = rank;
            Portrait = image;
            Address = address;
        }

        public OfficerDM() { }
    }
}
