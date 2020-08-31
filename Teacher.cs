using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace StudyLib
{

    public class Teacher : Person
    {
        private int _salery;
        
        
        public static readonly double Pi = Math.PI;

        public Teacher(string name, string address, int salery, GenderEnum gender) : base(name, address, gender)
        {
            Name = name;
            Address = address;
            Salery = salery;
            Gender = gender;
        }

        public int Salery
        {
            get => _salery;
            set { if (value < 0) throw new ArgumentOutOfRangeException();
                _salery = value; }
        }

       

        public override string ToString()
        {
            return $"Teacher earns {Salery}";
        }
    }
}
