using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Doctor:Person
    {
        public Doctor(string name,int age,char gender,int docTime):base(name,age,gender)
        {
            this.DocTime = docTime;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = Name; }
        }

        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private int _docTime;
        public int DocTime
        {
            get { return _docTime; }
            set { _docTime = value; }
        }

        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡~~~");
        }

        public void Cure()
        {
            Console.WriteLine("治病");
        }
    }
}
