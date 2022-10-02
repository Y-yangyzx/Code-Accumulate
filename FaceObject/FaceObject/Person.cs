using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceObject
{
    //public class Person
    //{
    //    private static string _name;
    //    public string Name
    //    {
    //        get { return _name; }
    //        set { _name = value; }
    //    }
    //    private int _age;
    //    public int Age
    //    {
    //        get { return _age; }
    //        set
    //        {
    //            //这判断的是你输入的那个值  也就是value
    //            if (value > 100 || value < 0)
    //            {
    //                value = -1;
    //            }
    //            _age = value;
    //        }
    //    }
    //    private char _gender;
    //    public char Gender
    //    {
    //        get
    //        {
    //            if (_gender != '男' && _gender != '女')
    //            {
    //                //return不写也可以  写上吧
    //                return _gender = '男';
    //            }
    //            //不用写一个else因为return会直接结束get这个方法
    //            return _gender;
    //        }
    //        set { _gender = value; }
    //    }

    //    public void CHLSS()
    //    {
    //        Console.WriteLine(_name);
    //        Console.WriteLine($"我叫{this.Name},我今年{this.Age}岁,我是{this.Gender}生,我可以吃喝拉撒睡呦");
    //    }
    //}

    //public class Person
    //{
    //    #region 字段属性方法
    //    //string _name;
    //    //public string Name
    //    //{
    //    //    get { return _name; }
    //    //    set { _name = value; }
    //    //}
    //    //int _age;
    //    //public int Age
    //    //{
    //    //    get { return _age; }
    //    //    set { _age = value; }
    //    //}
    //    //char _gender;
    //    //public char Gender
    //    //{
    //    //    get {
    //    //        //if (_gender!='男'||_gender!='女')
    //    //        //{
    //    //        //    return _gender = '男';
    //    //        //}
    //    //        return _gender;
    //    //    }
    //    //    set {
    //    //        if (value!='男'||value!='女')
    //    //        {
    //    //            value = '男';
    //    //        }
    //    //        _gender = value;
    //    //    }
    //    //}


    //    //public void CHLSS()
    //    //{
    //    //    Console.WriteLine("我不希望留下遗憾，尤其是我奋斗过想要得到的东西！命运总是捉弄人呐，愿有好运陪伴吧！");
    //    //    Console.WriteLine("我叫{0},我今年{1}岁,我是{2}生,我可以吃喝拉撒睡呦~~~~",this.Name,this.Age,this.Gender);
    //    //}
    //    #endregion


    //}


    public class Person
    {
        //构造函数
        public Person(string name,int age,char gender,int chinese,int english,int math)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.English = english;
            this.Math = math;
        }
        
        //冗余代码太多了  
        public Person(string name,int chinese,int english,int math):this(name,-1,'a',chinese,math,english)
        {
            //this.Name = name;
            //this.Chinese = chinese;
            //this.English = english;
            //this.Math = math;
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        
        public int Age
        {
            get {
                if (_age<0||_age>100)
                {
                    return _age = -1;
                }
                return _age; }
            set { _age = value; }
        }

        private char _gender;

        public char Gender
        {
            get { return _gender; }
            set {
                //if (value!='男'&&value!='女')
                //{
                //    value = '男';
                //}
                _gender = value; }
        }

        private int _chinese;

        public int Chinese
        {
            get { return _chinese; }
            set { _chinese = value; }
        }

        private int _math;

        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }

        private int _english;

        public int English
        {
            get { return _english; }
            set { _english = value; }
        }


        public void SayHellow()
        {
            Console.WriteLine("Hellow!");
        }

        public void CHLSS()
        {
            Console.WriteLine($"我叫{this.Name}，我今年{this.Age}岁,我是{this.Gender}生,我的语文成绩是{this.Chinese},我的数学成绩是{this.Math},我的英语成绩是{this.English},我可以吃喝拉撒睡~~~");
        }
    }
}
