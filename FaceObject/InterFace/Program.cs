using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 接口不能实例化 去指向一个子对象
            //接口
            //接口是不能实例化的，去指向一个子类对象
            //IFlyable fly = new Person();
            //IFlyable fly = new Bird();
            //fly.Fly();
            //Console.ReadKey();
            #endregion

            #region //显示实现接口就是为了解决方法的重命问题
            //调用的是接口的飞
            //IFlyable fly = new Bird();
            //fly.Fly();
            ////调用的是自己的飞
            //Bird bird = new Bird();
            //bird.Fly(); 
            //Console.ReadKey();
            #endregion

            //真的鸭子会游泳  木头鸭子不会游泳 橡皮鸭子会游泳（能力  用接口来做）
            //不能写抽象方法，因为真的鸭子需要被创建对象  虚方法也不合适，
            //因为木头鸭子不会游泳，不能写出一个共同的方法
            //所以用接口！！！


            ISwimming swimming = new RealDuck();
            swimming.swim();
            ISwimming sm = new XPDuck();
            sm.swim();
            Console.ReadKey();

        }
    }

    public class RealDuck : ISwimming
    {
        public void swim()
        {
            Console.WriteLine("真的鸭子靠脚丫游泳");
        }
    }

    public class MuDuck
    {

    }

    public class XPDuck:ISwimming
    {
        public void swim()
        {
            Console.WriteLine("橡皮鸭子飘着游泳");
        }
    }

    public interface ISwimming
    {
        void swim();
    }



    #region 显示实现接口
    //public class Bird:IFlyable
    //{
    //    //类中的成员，默认为private
    
    //    public void Fly()
    //    {
    //        Console.WriteLine("鸟会飞");
    //    }
    //    //这是方法是要实现继承接口而写的 所以在实例化接口时调用的就是它
    //    /// <summary>
    //    /// 显示实现接口
    //    /// </summary>
    //    void IFlyable.Fly()
    //    {
    //        Console.WriteLine("我是显示实现接口的飞");
    //    }
    //}

    //public interface IFlyable
    //{
    //    void Fly();
    //}
    #endregion


    #region 类和接口
    //public class Person : IFlyable
    //{
    //    public void Fly()
    //    {
    //        Console.WriteLine("我是继承接口的飞的方法");
    //    }
    //}

    //public class Bird : IFlyable
    //{
    //    public void Fly()
    //    {
    //        Console.WriteLine("鸟在飞");
    //    }
    //}


    ////接口不能被实例化
    //public interface IFlyable
    //{
    //    void Fly();
    //}


    //public interface m1
    //{
    //    void Test1();
    //}

    //public interface m2
    //{
    //    void Test2();
    //}
    //public interface m3
    //{
    //    void Test3();
    //}

    ////接口继承接口   并且接口只能继承接口
    //public interface SuperInterface:m1,m2,m3
    //{
    //    //接口是不能实现方法体的   接口继承接口不用实现其方法 
    //}

    //public class Car : SuperInterface
    //{
    //    public void Test1()
    //    {

    //    }

    //    public void Test2()
    //    {

    //    }

    //    public void Test3()
    //    {

    //    }
    //}
    #endregion
}
