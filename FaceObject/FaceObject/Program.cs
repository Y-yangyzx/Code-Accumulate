using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceObject
{
    //public struct s
    //{

    //}
    //public enum Gender
    //{

    //}

    class Program
    {
        private static string name = "我是私有变量，只能在类的内部使用";
        //利用静态变量模拟全局变量  
        static void Main(string[] args)
        {
            #region 
            ////类的实例化
            //Person person = new Person();
            ////用对象给字段赋值

            ////字段相当于女人 所以要保护起来
            //person.Name="张三";
            //person.Age = -3;
            //person.Gender = '男';
            //person.CHLSS();
            //Console.ReadKey();
            #endregion

            #region
            //Person person = new Person();
            //person.Name = "张三";
            //person.Age = 18;
            //person.Gender = '夏';
            //person.CHLSS();
            //Console.ReadKey();
            //Console.WriteLine(name);
            #endregion


            #region 面向对象

            //问题：这样在初始化对象的时候比较麻烦 构造函数帮助我们初始化对象
            //Person person = new Person("张三",100,100,100);
            //person.Name = "张三";
            //person.Age = 18;
            //person.Gender = '中';
            //person.Chinese = 100;
            //person.Math = 100;
            //person.English = 100;
            //person.SayHellow();
            //person.CHLSS();



            //Person lsperson = new Person("李四",16,'女',50,50,50);
            //赋值最后还是要使用  在哪里使用呢？在方法中使用，写一个方法将属性传进去
            //本例中SayHellow()方法使用了值
            //lsperson.Name = "李四";
            //lsperson.Age = 16;
            //lsperson.Gender = '女';
            //lsperson.Chinese = 50;
            //lsperson.Math = 80;
            //lsperson.English = 30;
            //lsperson.SayHellow();
            //lsperson.CHLSS();
            //使程序暂停  只需要结尾放一个就ok了
            #endregion


            //Ticket ticket = new Ticket(146);
            //ticket.GetPrice();
            //Console.ReadKey();


            #region 将字符串看做是字符型数组
            //string s = "abcde";
            ////这是只读的
            //Console.WriteLine(s[0]);

            //char[] ch = s.ToCharArray();
            ////把第一个字符改成b之后 s这个字符串并没有改变 改变的是ch这个字符数组
            //ch[0] = 'b';
            ////再将ch这个字符数组转为字符串
            //s = new string(ch);
            //Console.WriteLine(s);
            #endregion


            StringBuilder sb = new StringBuilder();

            //创建一个计时器

            #region StringBuilder
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //string str = null;
            //for (int i = 0; i < 100000; i++)
            //{
            //    //str += i;
            //    //慢：不停开空间
            //    //00:00:00.0136469
            //    sb.Append(i);
            //}
            //sw.Stop();
            //Console.WriteLine(sb.ToString());
            //Console.WriteLine(sw.Elapsed);
            #endregion


            #region 大小写
            // Console.WriteLine("请输入课程");
            // string lessonOne = Console.ReadLine();
            //// lessonOne= lessonOne.ToUpper();
            // Console.WriteLine("请输入课程");
            // string lessonTwo = Console.ReadLine();
            // //lessonTwo= lessonTwo.ToUpper();
            // if (lessonOne.Equals(lessonTwo,StringComparison.OrdinalIgnoreCase))
            // {
            //     Console.WriteLine("你们两个喜欢的课程相同");
            // }
            // else
            // {
            //     Console.WriteLine("你们两个喜欢的课程不同");
            // }
            #endregion

            #region  分割字符串
            //string str = "asd fr , _ qw w r + ,. + kj";
            ////需求去掉出字母以外的其他字符
            //char[] chs = { ',',' ','+','.','_'};
            //string[] s= str.Split(chs,StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.Write(s[i]); 
            //}

            //string str = "2022-9-23";
            //char[] chs = { '_' };
            //string[] date = str.Split(new char[] { '-' },StringSplitOptions.RemoveEmptyEntries);
            #endregion

            #region  StarsWith()  Endwith()
            //string str = "今天天气有点冷，注意增加衣物莫感冒！";
            //if (str.EndsWith("！"))
            //{
            //    Console.WriteLine(1);
            //}
            //else
            //{
            //    Console.WriteLine(0);
            //}
            #endregion

            //Indexof()     LastIndexof()
            string str = "今天天气有点冷，注意增加衣物莫感冒！";
            int index= str.IndexOf('天');
            Console.WriteLine(index);


            Console.ReadKey();
        }
    }
}
