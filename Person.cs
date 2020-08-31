using System;
using System.Collections.Generic;
using System.Text;

namespace StudyLib
{
    public enum GenderEnum
    {
        Male,
        Female
    }
    public class Person
    {
        private string _name;
        private string _address;
        private GenderEnum _gender;

        public Person(string name, string address, GenderEnum gender)
        {
            Name = name;
            Address = address;
            Gender = gender;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (value.Length < 1) throw new ArgumentException();
                _name = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (value.Length < 2) throw new ArgumentException();
                _address = value;
            }
        }

        public GenderEnum Gender
        {
            get => _gender;
            set => _gender = value;

        }
    }
}
