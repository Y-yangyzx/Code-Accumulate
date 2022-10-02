using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Student : Person
    {
        public Student(string name, int age, char gender, int id) : base(name,age,gender)
        {
            //this.Name = _name;
            //this.Age = _age;
            //this.Gender = _gender;
            this.Id = id;
        }

        //private string _name;
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        //private char _gender;
        //public char Gender
        //{
        //    get { return _gender; }
        //    set { _gender = value; }
        //}

        //private int _age;
        //public int Age
        //{
        //    get { return _age; }
        //    set { _age = value; }
        //}

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡~~~");
        }

        public void Stundy()
        {
            Console.WriteLine("学习");
        }
    }
}
