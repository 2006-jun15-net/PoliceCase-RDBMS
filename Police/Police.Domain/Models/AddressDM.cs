using System;
using System.Collections.Generic;
using System.Text;

namespace Police.Domain.Models
{
    class AddressDM
    {
        private string _street;
        private string _city;
        private string _state;
        private int _zipcode;

        public int ID { get; set; }
        public string Street 
        {
            get => _street; 
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Street cannot be empty", nameof(value));
                }
                _street = value;
            }
        }

        public string City 
        {
            get => _city;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("City cannot be empty", nameof(value));
                }
                _city = value;
            }
        }

        public string State 
        {
            get => _state;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("State cannot be empty", nameof(value));
                }
                _state = value;
            }
        }
        public int Zipcode 
        {
            get => _zipcode;
            set
            {
                if (value.ToString().Length != 5)
                {
                    throw new ArgumentException("Zipcode must be 5 digits long", nameof(value));
                }
                _zipcode = value;
            }
        }
    }
}
