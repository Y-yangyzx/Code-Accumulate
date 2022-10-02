using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_LSXH
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Person p = new Person();
            //p.PerSayHellow();
            //Studet s = new Studet();
            //s.StuSayHellow();
            //s.PerSayHellow();

            //里式转换
            //子类可以赋值给父类
            //Person p = new Studet();
            //p.PerSayHellow();

            //如果父类对象中装的是子类对象 可以将这个对象强转为子类对象类型
            //if (p is Studet)
            //{
            //    Studet t = (Studet)p;
            //    t.StuSayHellow();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败！");
            //}

            //Teacher s = p as Teacher;
            //s.TeaSayHellow();
            #endregion

            #region 用字符串方法取得文件名
            //string str = @"D:\2932189904\Video";
            //int index = str.LastIndexOf("\\");
            //str = str.Substring(index + 1);
            //Console.WriteLine(str);

            //str = Path.GetFileName(str);
            //Console.WriteLine(str);
            #endregion


         
            //Person[] pers = new Person[8];
            Cn cn1 = new Cn("张三");
            Cn cn2 = new Cn("李四");
            Jap jap1 = new Jap("渡边雄太");
            Jap jap2 = new Jap("三目洋子");
            Am am1 = new Am("史密斯");
            Am am2 = new Am("詹姆斯");
            Ke ke1 = new Ke("朴仁贤");
            Ke ke2 = new Ke("金秀贤");
            Person[] pers = { cn1,cn2,jap1,jap2,am1,am2,ke1,ke2,new UK("亚索"),new UK("马克")};


            for (int i = 0; i < pers.Length; i++)
            {
                //表现出来的都是父类的类型
                //pers[i].SayHellow();

                //if (pers[i] is Cn)
                //{
                //    ((Cn)pers[i]).SayHellow();
                //}
                //else if(pers[i] is Jap)
                //{
                //    ((Jap)pers[i]).SayHellow();
                //}
                //else if (pers[i] is Am)
                //{
                //    ((Am)pers[i]).SayHellow();
                //}
                //else
                //{
                //    ((Ke)pers[i]).SayHellow();
                //}

                pers[i].SayHellow();
            }
            
            Console.ReadKey();
        }

        #region
        //public class Person
        //{
        //    public void PerSayHellow()
        //    {
        //        Console.WriteLine("我是Person中的Hellow");
        //    }
        //}

        //public class Studet : Person
        //{
        //    public void StuSayHellow()
        //    {
        //        Console.WriteLine("我是Student中的Hellow");
        //    }

        //}

        //public class Teacher : Person
        //{
        //    public void TeaSayHellow()
        //    {
        //        Console.WriteLine("我是Teacher中的Hellow");
        //    }

        //}
        #endregion

        public class Person
        {
            private string _name;
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public Person(string name)
            {
                this.Name = name;
            }

            public virtual void SayHellow()
            {
                Console.WriteLine("我是人类");
            }
        }

        public class Cn : Person
        {
            //没必要写了，因为继承了父类的，再写一个相同的重名了父类的成员会被隐藏


            //private string _name;
            //public string Name
            //{
            //    get { return _name; }
            //    set { _name = value; }
            //}
            public Cn(string name) : base(name)
            {

            }

            public override void SayHellow()
            {
                Console.WriteLine("我是中国人，我叫{0}", this.Name);
            }
        }

        public class Jap:Person
        {
            public Jap(string name):base(name)
            {

            }

            public override void SayHellow()
            {
                Console.WriteLine("我是日本人，我叫{0}",this.Name);
            }
        }

        public class Am:Person
        {
            public Am(string name):base(name)
            {
                
            }

            public override void SayHellow()
            {
                Console.WriteLine("我是米国人，我叫{0}",this.Name);

            }
        }

        public class Ke:Person
        {
            public Ke(string name):base(name)
            {

            }

            public override
 void SayHellow()
            {
                Console.WriteLine("我是思密达，我叫{0}",this.Name);
            }
        }

        public class UK:Person
        {
            public UK(string name):base(name)
            { }

            public override void SayHellow()
            {
                Console.WriteLine("我是英国人，我叫{0}",this.Name);
            }
        }

    }
}
