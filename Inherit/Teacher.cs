using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Teacher:Person
    {
        public Teacher(string name,char gender,int age,int salary):base(name,age,gender)
        {
            this.Salary = salary;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = Name; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡~~~");
        }

        public void Teach()
        {
            Console.WriteLine("讲课");
        }
    }
    
}
