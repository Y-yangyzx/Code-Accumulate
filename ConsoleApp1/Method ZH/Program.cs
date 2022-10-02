using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_ZH
{
    class Program
    {
        //最少一共有9个例子 都要练完！！！

        static void Main(string[] args)
        {
            #region ***方法的一个小总和练习
            //方法的总和练习
            //要求用户输入两个数字 要求求两个数字之间所有整数和
            //1.用户只能输入数字  2.计算两个数字之间的和  3.第一个数字要大于第二个数字
            //    Console.WriteLine("请输入第一个数字：");
            //    string strNumber1 = Console.ReadLine();
            //    int num1=GetNum(strNumber1);
            //    Console.WriteLine("请输入第二个数字：");
            //    string strNumber2 = Console.ReadLine();
            //    int num2= GetNum(strNumber2);

            //    JudgeNum(ref num1,ref num2);

            //    int sum = GetSum(num1,num2);
            //    Console.WriteLine(sum);
            //    Console.ReadKey();

            //}
            ////***
            //public static int GetNum(string s)
            //{
            //    while (true)
            //    {
            //        try
            //        {
            //            int num = Convert.ToInt32(s);
            //            return num;
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入有误，请重新输入！");
            //            s = Console.ReadLine();
            //        }
            //    }

            //}

            ////***
            //public static void JudgeNum(ref int n1,ref int n2)
            //{
            //    while (true)
            //    {
            //        if (n1 < n2)
            //        {
            //            return;
            //        }
            //        else
            //        {
            //            //重新输入先不要转为字符串
            //            Console.WriteLine("第一个数字要小于等于第二个数字，请重新输入：");
            //            string s1 = Console.ReadLine();
            //            n1 = GetNum(s1);
            //            Console.WriteLine("请输入第二个数字：");
            //            string s2 = Console.ReadLine();
            //            n2 = GetNum(s2);
            //        }
            //    }

            //}

            //public static int GetSum(int n1,int n2)
            //{
            //    int sum = 0;
            //    for (int i = n1; i <= n2; i++)
            //    {
            //        sum += i;
            //    }
            //    return sum;
            //}
            #endregion

            #region 方法练习--找字符串数组中最长的元素输出
            //    //输出字符串数组中最长的那个元素（写一个方法）
            //    string[] names = { "迈克尔乔丹", "科比布莱恩特", "蒂姆邓肯", "雷布朗站木塑", "卡尔那龙" };
            //    string maxlong = GetLong(names);
            //    Console.WriteLine(maxlong);
            //    Console.ReadLine();

            //}

            //public static string GetLong(string[] s)
            //{
            //    在这定义一个字符串类型的变量去接收 返回的就是这个数组中的元素
            //    string max = s[0];
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        if (s[i].Length > max.Length)
            //        {
            //            max = s[i];
            //        }
            //    }
            //    return max;  //返回的是数组中最长元素的名字

            //    int max = s[0].Length;
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        if (s[i].Length > max)
            //        {
            //            max = s[i].Length;
            //        }
            //    }
            //    return max;   //返回的是数组中最长元素的长度
            //}
            #endregion


            #region 字符串方法
            //用一个方法实现：一个整型数组的平均值  保留两位小数(不是输出时保留两位)
            //将avg本身转为两位小数 先转为字符串再转回来

            int[] arr = { 1,2,7};
            double avg = Get_avg(arr);

            //先转为字符串  再转回double
            string savg = avg.ToString("0.00");
            avg = Convert.ToDouble(savg);

            //输出转换为保留两位小数
            //Console.WriteLine("{0:0.00}", avg);
            Console.WriteLine(avg);
            Console.ReadKey();
            #endregion
        }

        #region
        public static double Get_avg(int[] arr)
        {
            //int sum = 0;
            double sum = 0;
            //double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum/arr.Length;
        }
        #endregion
    }
}
