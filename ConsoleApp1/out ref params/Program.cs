using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_ref_params
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  //方法的三个高级参数---out
            //想要返回一个int类型数组的最大值、最小值、总和、平均值  可以返回一个数组类型
            //int[] arr = { 1, 2, 3, 4, 5};
            ////对应实参没有 声明  
            ////在这并不需要给实参赋值  因为在方法GetOut中依次的给这几个变量赋值了
            //int max;
            //int min;
            //int sum;
            //int avg;
            //bool b;
            //double d;
            //GetOut(arr, out max,out min,out sum,out avg,out b,out d);
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            //Console.WriteLine(sum);
            //Console.WriteLine(avg);
            //Console.WriteLine(b);
            //Console.WriteLine(d);

            //int[] res = GetArr(arr);
            //for (int i = 0; i < res.Length; i++)
            //{
            //    Console.WriteLine(res[i]);
            //}          
            //Console.ReadKey();
            #endregion

            #region //out参数的练习
            //分别提示输入用户名和密码 写一个方法判断二者是否正确
            //返回结果:1.登录结果（成功/失败） 2.用户名错误/密码错误
            //Console.WriteLine("请输入用户名：");
            //string userName = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //string passWord = Console.ReadLine();
            //string msg;
            //bool b = Log(userName, passWord, out msg);
            //Console.WriteLine(b);
            //Console.WriteLine(msg);
            //Console.ReadKey();
            #endregion

            #region //out参数的练习二   通过自己写方法实现和TryParse()功能一样的方法
            //int num;
            ////bool b = int.TryParse("123", out num);
            //bool b = MyParse("123abc", out num);
            //Console.WriteLine(b);
            //Console.WriteLine(num);
            //Console.ReadKey();
            #endregion



            #region //ref参数
            //例子：用一个方法实现交换变量
            //int a = 10;
            //int b = 20;
            ////没有把交换后的值返回回来
            //Exchange(ref a,ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.ReadKey();
            #endregion


            //params可变参数
            //int[] score = { 99, 98, 97 };
            Test("张三",99,98,97);
            Console.ReadKey();

            //params常用的例子：求任意长度数组的和  整数类型的

        }

        //params可变参数的方法
        public static void Test(string name,params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}的总分是{1}",name,sum);
        }


        #region 交换两个变量的方法
        public static void Exchange(ref int n1,ref int n2)
        {
            int tmp = 0;
            tmp = n1;
            n1 = n2;
            n2 = tmp;
        }
        #endregion


        #region //out参数第二个练习方法
        public static bool MyParse(string s,out int result)
        {
            result = 0;
            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                
                return false;
            }
            
        }
        #endregion


        #region out参数练习的方法
        //out参数练习
        public static bool Log(string username,string password,out string msg)
        {
            if (username =="admin"&&password=="123456")
            {
                msg = "都对了";
                return true;
            }
            else if (username=="admin")
            {
                msg = "密码错误";
                return false;
            }
            else if (password=="123456")
            {
                msg = "账号错误";
                return false;
            }
            else
            {
                msg = "均错误";
                return false;
            }
        }
        #endregion


        #region 利用out参数返回多个不同类型的值
        public static void GetOut(int[] arr,out int max,out int min,out int sum,out int avg,out bool b,out double d)
        {
            //写了out的参数一定要在方法内给它赋值
            max = arr[0];
            min = arr[0];
            sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i]<min)
                {
                    min = arr[i];
                }
                sum += arr[i];
            }
            avg = sum / arr.Length;
            b = true;
            d = 3.14;
        }
        #endregion

       
        
        
        
        #region //返回数组 同类型
        public static int[] GetArr(int[] arr)
        {
            int[] res = new int[4]; //声明一个数组来接收返回值
            res[0] = arr[0];//max
            res[1] = arr[1];//min
            res[2] = 0; //sum
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > res[0])
                {
                    res[0] = arr[i];
                }
                if (arr[i] < res[1])
                {
                    res[1] = arr[i];
                }
                res[2] += arr[i];
            }
            res[3] = res[2] / arr.Length;
            return res;
        }
        #endregion
    }
}
