using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        #region 自定义方法
        //写一个函数 判断一个年份是否是闰年
        /// <summary>
        /// 判断一个函数是否是闰年的函数
        /// </summary>
        /// <param name="year">要判断的年份</param>
        /// <returns>返回一个bool类型 是闰年返回true 不是返回false</returns>
        //public static bool IsRun(int year)
        //{
        //    bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        //    return b;
        //}

        //public static int GetNumber(string n)
        //{
        //    while (true)
        //    {       
        //        try
        //        {
        //            int ret = Convert.ToInt32(n);
        //            return ret;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("输入有误，请重新输入！");
        //            n = Console.ReadLine();
        //        }              
        //    }
        //}


        //public static string Answer(string input)
        //{
        //    while (true)
        //    {
        //        if (input =="yes"||input=="no")
        //        {

        //            //还是要返回一下
        //            return input;
        //        }
        //        else
        //        {
        //            Console.WriteLine("请重新输入！");
        //            input = Console.ReadLine();
        //        }
        //    }
        //}

        ///// <summary>
        ///// 求一个整数数组的总和
        ///// </summary>
        ///// <param name="arr">传入一个数组</param>
        ///// <returns>返回总和</returns>
        //public static int GetSum(int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        #endregion

        #region
        public static int Test(int a)
        {
            a = a + 5;
            return a;
        }


        public static int GetNumber(string input)
        {
            while (true)
            {
                //判断一个数是否是数字用try-catch 而我们容易先想到if-else

                try
                {
                    int num = Convert.ToInt32(input);
                    return num;
                }
                catch
                {
                    Console.WriteLine("请重新输入！");
                    input = Console.ReadLine();
                }
            }            
        }

        //返回多个值
        public static int[] GetMaxMinSumAvg(int[] arr)
        {
            int[] res = new int[4];
            res[0] =arr[0];
            res[1] = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                res[2] += arr[i];
            }
            res[3] = res[2] / arr.Length;
            return res;
        }
#endregion

        static void Main(string[] args)
        {

            #region 
            //while (true)
            //{
            //    Console.WriteLine("请输入要判断的年份：");
            //    int year = Convert.ToInt32(Console.ReadLine());
            //    bool b= IsRun(year);
            //    Console.WriteLine(b);
            //}

            #region 方法的例子 ***
            //读取输入的整数，定义成方法
            //多次调用（如果用户输入的是数字，则返回，否则提示用户重新输入！）
            //while (true)
            //{
            //    Console.WriteLine("请输入整数：");
            //    try
            //    {
            //        int Number = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine(Number);
            //        break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入错误请重新输入！");
            //    }               
            //}
            //Console.ReadKey();


            //Console.WriteLine("请输入一个整数：");
            //string s = Console.ReadLine();
            //int ret = GetNumber(s);
            //Console.WriteLine(ret);
            //Console.ReadKey();



            //***
            //读取输入的整数，定义成方法
            //多次调用（如果用户输入的是数字，则返回，否则提示用户重新输入！）
            //Console.WriteLine("请输入数字：");
            //string input = Console.ReadLine();
            //int num= GetNumber(input);
            //Console.WriteLine(num);
            //Console.ReadKey();



            //要求用户只能输入yes或no
            //这个方法做了什么事情？只能让用户输入yes或者no，只要不是就
            //重新输入
            //Console.WriteLine("请输入yes/no");
            //string input = Console.ReadLine();
            //string answer= Answer(input);
            //Console.WriteLine(answer);
            //Console.ReadKey();



            //写一个方法  计算数组的总和
            //int[] arr = {1,2,3,4,5,6,7,8,9,10};
            //int sum= GetSum(arr);
            //Console.WriteLine(sum);
            //Console.ReadLine();
            #endregion


            //int a = 3;
            //int ret = Test(a);
            //Console.WriteLine(ret);
            //Console.ReadKey();


            //返回最大值 最小值 总和 平均值
            //int[] arr = { 1,2,3,4,5,6,7};
            //int[] a = GetMaxMinSumAvg(arr);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            //Console.ReadLine();

            #endregion

            //冒泡排序 三个高级参数  方法的递归  到p86（始）


            //冒泡排序：将一个数组中的元素按照由小到大 或 由大到小的顺序进行排序
            //思路分析  交换 第一个数分别和后边的每一个数进行比较 谁大谁放在后边
            //10个数要比较九趟  每一趟会交换x次
            //第一趟就是把最大的放到最后（升序）第二趟再把剩余最大的排在最后 以此类推
            //int[] nums = { 8, 1, 2, 6, 5, 7, 3, 4, 9, 0 };
            //Array.Sort(nums); //对一个数组进行升序排列

            ////比价九趟 i从0开始 i<9就是比较9趟 而nums.Length=10
            //for (int i = 0; i < nums.Length-1; i++)
            //{
            //    for (int j = 0; j < nums.Length-1-i; j++)
            //    {
            //        if (nums[j]>nums[j+1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();



            //递归

            //TellStory();
            //Console.ReadKey();



        }


        #region 递归
        //public static int i = 0;  //全局变量

        //public static void TellStory()
        //{
        //    //int i = 0;    每一次都会把i再赋值为0

        //    Console.WriteLine("从前有座山,");
        //    Console.WriteLine("山里有座庙,");
        //    Console.WriteLine("庙里有个老和尚和小和尚，");
        //    Console.WriteLine("老和尚给小和尚将一个故事：");
        //    i++;
        //    if (i>10)
        //    {
        //        return;
        //    }
        //    TellStory();
        //}
        #endregion

    }
}
