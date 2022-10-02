using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaceObject;

namespace FaceObkectFromtoFrom
{
    class Program
    {
        static void Main(string[] args)
        {
            //这是另一个项目  问题：如何在一个项目中去访问另一个项目中的类  
            //引入要访问类的命名空间
            Person person = new Person("张三",100,100,100);
            person.SayHellow();
            person.CHLSS();
            Console.ReadKey();

        }
    }
}
