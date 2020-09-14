﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Police.Domain.Models
{
    public class CriminalDM
    {
        private string _firstName;
        private string _lastName;
        private string _sex;

        public int ID { get; set; }
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
        public string Sex 
        {
            get => _sex;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Sex cannot be empty", nameof(value));
                }
                if(value != "Male" && value != "Female" && value != "Other")
                {
                    throw new ArgumentException("Sex must either be Male, Female, or Other", nameof(value));
                }
                _sex = value;
            }
        }
        public int? Age { get; set; }
        public DateTime? DOB { get; set; }
        public string BodyMarks { get; set; }
        public byte[] Portrait { get; set; }
        public int? CurrentAddress { get; set; }

        public CriminalDM(int id, string firstName, string lastName, string sex, int? age, DateTime? dob, string bodymarks, byte[] image, int? currentAddress)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            Age = age;
            DOB = dob;
            BodyMarks = bodymarks;
            Portrait = image;
            CurrentAddress = currentAddress;
        }

        public CriminalDM() { }
    }
}
