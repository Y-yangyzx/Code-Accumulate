using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Programer : Person
    {
        public Programer(string name, int age, char gender, string hobby) : base(name, age, gender)
        {
            this.Hobby = hobby;
        }

        //private string _name;
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        //private int _age;
        //public int Age
        //{
        //    get { return _age; }
        //    set { _age = value; }
        //}

        //private char _gender;
        //public char Gender
        //{
        //    get { return _gender; }
        //    set { _gender = value; }
        //}

        private string _hobby;
        public string Hobby
        {
            get { return _hobby; }
            set { _hobby = value; }
        }

        public void ProgramerSayHellow()
        {
            Console.WriteLine($"我叫{this.Name}，我是一名程序员，我是{this.Gender}生，我今年{this.Age}岁，我的爱好是{this.Hobby}");
        }

    }
}
