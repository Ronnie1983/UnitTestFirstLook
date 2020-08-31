using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace StudyLib
{
    
    public class Student:Person
    {
        private int _semester;

        public Student(string name, string address, int semester, GenderEnum gender) : base(name, address, gender)
        {
            Name = name;
            Address = address;
            Semester = semester;
            Gender = gender;
        }

     

        public int Semester
        {
            get => _semester;
            set
            {
                if (value > 8 || value < 1) throw new ArgumentOutOfRangeException();
                    _semester = value;
            }
        }

        public override string ToString()
        {
            return $"Student goes at {Semester} semester";
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || this.GetType() != obj.GetType())
            {
                return false;
            } else {
                return true;
            }

        }
        // mangler mere præcis info til denne
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
