using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0919_Start_enum
{
    //public enum Gender
    //{
    //    男,
    //    女
    //}

    //public enum season
    //{
    //    春,
    //    夏,
    //    秋,
    //    冬
    //}

    //public struct Person
    //{
    //    public string name;
    //    public int age;
    //    public char gender;
    //    public Gender gg;
    //}

    //public struct Mycolor
    //{
    //    public int _red;
    //    public int _yellow;
    //    public int _green;
    //}


    public struct Person
    {
        public string _name;
        public int _age;
        public string _gender;
    }

    class Program
    {


        //Console.ReadKey();
        //方法
        //static int GetMax(int n1, int n2)
        //{
        //    return n1 > n2 ? n1 : n2;
        //}
        //用静态字段来模拟全局变量
        //public static int _Number = 100;


        //public static int Test(int a)
        //{
        //    a = a + 5;
        //    return a;
        //}
 

        static void Main(string[] args)
        {
            //int max = Program.GetMax(1, 2);
            //Console.WriteLine(max);

            //int a = 3;
            //int ret = Test(a);
            //Console.WriteLine(ret);
            //Console.WriteLine(_Number);
            //Console.ReadKey();



            #region 数组例子

            //计算数组中的最大值、最小值、总和、平均值
            //int[] arr = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int max = arr[0];
            //int min = arr[0];
            //int sum = 0;
            //int i = 0;
            //for ( i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]>max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i]<min)
            //    {
            //        min = arr[i];
            //    }
            //    sum += arr[i];
            //}
            //Console.WriteLine($"这个数组最大值是{max}，最小值是{min}，总和是{sum}，平均值是{sum/i}");



            //数组的例子
            //将数组中的人名 以老赵|老钱|老孙|老李|老周|老吴 方式输出
            //方法一：
            //string[] names = { "老赵","老钱","老孙","老李","老周","老吴"};
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (i!=names.Length-1)
            //    {
            //        names[i] += "|";
            //    }

            //}
            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.Write(names[j]);
            //}
            //Console.ReadKey();



            //方法二：
            //将这个数组循环加到一个字符串中+"|"  然后输出
            //string str = null;
            //string[] names = { "老赵", "老钱", "老孙", "老李", "老周", "老吴" };
            //for (int i = 0; i < names.Length-1; i++)
            //{
            //    //if (i!=names.Length-1)
            //    //{
            //    //    str += names[i] + "|";
            //    //}
            //    //else
            //    //{
            //    //    str += names[i];
            //    //}

            //    str += names[i] + "|";

            //    //names[i] 两种解释 ：代表循环到的那一个元素 是一个string类型的
            //}
            //Console.WriteLine(str+names[names.Length-1]);
            //Console.ReadKey();


            //将一个整数数组进行判断  正数+1  负数-1  如果是0则，不变
            //int[] num = { 0,1,-2,3,-4,5,6,7,-8,9};
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i]>0)
            //    {
            //        num[i] += 1;
            //    }
            //    else if (num[i]<0)
            //    {
            //        num[i] -= 1;
            //    }
            //    else
            //    {

            //    }
            //}
            //for (int j = 0; j < num.Length; j++)
            //{
            //    Console.WriteLine(num[j]);
            //}
            //Console.ReadKey();


            //将一个字符串数组倒序输出  {"我","是","好人"}   {"好人","是","我"}
            //n个元素交换n/2次
            //string[] str = { "我", "是", "好人" };
            //for (int i = 0; i < str.Length/2; i++)
            //{
            //    string temp = "";
            //    temp = str[i];
            //    str[i] = str[str.Length - 1 - i];
            //    str[str.Length - 1 - i] = temp;
            //}
            //for (int j = 0; j < str.Length; j++)
            //{
            //    Console.Write(str[j]);
            //}
            //Console.ReadKey();



            //***冒泡排序 




            #endregion

            //冒泡排序
            int[] arr = { 3,2,1, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j ] = arr[j+1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.ReadKey();



            #region 折叠要使用
            //Person zsperson; //张三这个对象
            //对象中的成员
            //zsperson._name = "张三";   
            //zsperson._age = 18;
            //zsperson._gender = "男";

            //Person xlperson;//小兰这个对象
            //xlperson._name = "小兰";
            //Console.WriteLine(zsperson._name);
            //Console.WriteLine(xlperson._name);



            //int[] num = new int[10];
            //int[] num2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < num2.Length; i++)
            //{
            //    Console.WriteLine(num2[i]);
            //}





            //Mycolor mycolor;
            //mycolor._red = 255;
            //mycolor._yellow = 0;
            //mycolor._green = 0;



            //Person person;
            //person.name="张三";
            //person.age = 18;
            //person.gender = '男';

            //Console.WriteLine("{0}{1}{2}",person.age,person.name,person.gender);
            //Person p;
            //p.gg = Gender.女;

            //Person person;
            //person.gg = Gender.男;
            //Console.WriteLine(person.gg);




            ////类比变量的声明 赋值
            ////int a = 32;
            //Gender gender = Gender.女;

            //season s = season.秋;
            ////Console.WriteLine(gender);


            //int 转为枚举
            //int a = 5;  //转换不了的就直接输出这个数字
            ////int和枚举相兼容  强制类型转换
            //season season = (season)a;
            //Console.WriteLine(season);    //输出season 


            //枚举 转为int
            //season s = season.冬;
            //int a = (int)s;
            //Console.WriteLine(a);


            //枚举转为字符串  
            //season season = season.春;
            //string str = season.ToString();
            //Console.WriteLine(str);


            //字符串转为枚举
            //string str = "0";
            //season season= (season)Enum.Parse(typeof(season), str);
            //Console.WriteLine(season);
            #endregion


        }

    }
}

