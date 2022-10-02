using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic
{
    class Program
    {
        static void Main(string[] args)
        {

            #region //一、真的鸭子嘎嘎叫 木头鸭子吱吱叫 橡皮鸭子唧唧叫
            //Duck duck = new Duck();
            //MuDuck muDuck = new MuDuck();
            //XpDuck xpDuck = new XpDuck();
            //Duck[] ducks = { duck, muDuck, xpDuck };
            //for (int i = 0; i < ducks.Length; i++)
            //{
            //    ducks[i].Say();
            //}
            //Console.ReadKey();
            #endregion

            #region //二、员工7点打卡 经理9点打卡 程序猿不打卡
            //Employ employ = new Employ();
            //Manager manager = new Manager();
            //Programer programer = new Programer();
            //Employ[] employs = { employ, manager, programer };
            //for (int i = 0; i < employs.Length; i++)
            //{
            //    employs[i].DaKa();
            //}
            //Console.ReadKey();
            #endregion


            #region //三、抽象类  猫咪会叫 狗子也会叫 （你要抽象出一个父类出来）
            //Aniaml aniaml = new Aniaml();  不可以
            //Aniaml aniaml = new Dog();
            //调用的虽然是父类Animal中的Bark()方法 但是父类中的方法被子类中
            //的方法重写了 所以最终输出的是子类的打招呼方法 装的谁的对象就会
            //调用谁的方法
            //aniaml.Bark();
            //Console.ReadKey();
            #endregion

            #region //四、抽象类练习  使用多态求矩形的面积和周长以及圆形的面积和周长
            //抽象出来一个父类  Shape 形状父类
            //Shape s = new Cricle(5);
            //double area = s.GetArea();
            //double perimeter = s.GetPerimetre();
            //Console.WriteLine($"半径为5的圆，面积是{area}，周长是{perimeter}");

            //Shape ss = new Rectangle(3,4);
            //double Rearea = ss.GetArea();
            //double RePerimeter = ss.GetPerimetre();
            //Console.WriteLine($"长为3宽为4的矩形的面积是{Rearea},周长是{RePerimeter}");
            //Console.ReadKey();
            #endregion

            //五、用多态来实现移动硬盘或者U盘或者MP3插在电脑上 进行读写数据




        }



        #region 四、抽象类的三个类 Shape Cricle Rectangle
        //public abstract class Shape
        //{
        //    //不同形状求求面积的方法是不一样的  所以无法确定方法体
        //    public abstract double GetArea();
        //    public abstract double GetPerimetre();
        //}
        //public class Cricle:Shape
        //{
        //    //这个字段是用来存圆的半径的
        //    private double _r;
        //    public double R
        //    {
        //        get { return _r; }
        //        set { _r = value; }
        //    }
        //    //在初始化对象的时候传入值
        //    public Cricle(double r)
        //    {
        //        this.R = r;
        //    }

        //    //继承了抽象父类 子类中的方法要重写
        //    public override double GetArea()
        //    {
        //        return Math.PI * this.R * this.R;
        //    }

        //    public override double GetPerimetre()
        //    {
        //        return 2 * 3.14 * this.R;
        //    }
        //}

        //public class Rectangle:Shape
        //{
        //    private double _height;
        //    public double Height
        //    {
        //        get { return _height; }
        //        set { _height = value; }
        //    }
        //    private double _width;
        //    public double Width
        //    {
        //        get { return _width; }
        //        set { _width = value; }
        //    }

        //    public Rectangle(double height,double width)
        //    {
        //        this.Height = height;
        //        this.Width = width;
        //    }
        //    public override double GetArea()
        //    {
        //        return _width * _height;
        //    }
        //    public override double GetPerimetre()
        //    {
        //        return (_width + _height) * 2;
        //    }

        //}
        #endregion


        #region 三、抽象类 抽象方法 猫狗叫
        //public abstract class Aniaml
        //{
        //    public abstract void Bark();
        //    //{
        //    //    //这你不知道要写什么
        //    //}
        //}
        //public class Cat:Aniaml
        //{
        //    public override void Bark()
        //    {
        //        Console.WriteLine("猫咪喵喵叫");
        //    }
        //}
        //public class Dog:Aniaml
        //{
        //    public override void Bark()
        //    {
        //        Console.WriteLine("狗狗旺旺叫");
        //    }
        //}
        #endregion


        #region 二、员工 经理 程序猿 类
        //public class Employ
        //{
        //    public virtual void DaKa()
        //    {
        //        Console.WriteLine("我是员工，我7点打卡。");
        //    }
        //}

        //public class Manager:Employ
        //{
        //    public override void DaKa()
        //    {
        //        Console.WriteLine("我是经理，我11点打卡。");
        //    }
        //}

        //public class Programer:Employ
        //{
        //    public override void DaKa()
        //    {
        //        Console.WriteLine("我是程序猿，我不打卡。");
        //    }
        //}
        #endregion

        #region 一、三个Duck类
        //public class Duck
        //{
        //    public virtual void Say()
        //    {
        //        Console.WriteLine("嘎嘎叫");
        //    }
        //}

        //public class MuDuck:Duck
        //{
        //    public override void Say()
        //    {
        //        Console.WriteLine("吱吱叫");
        //    }
        //}

        //public class XpDuck:Duck
        //{
        //    public override void Say()
        //    {
        //        Console.WriteLine("唧唧叫");
        //    }
        //}
        #endregion
    }
}
