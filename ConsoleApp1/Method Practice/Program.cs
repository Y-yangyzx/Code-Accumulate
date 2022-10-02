using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法的练习

            #region double类型保留两位小数 思路：先转为字符串保留两位小数再转回double类型
            //double d = 3.1415926;
            //string dd = d.ToString("0.00");
            //d= Convert.ToDouble(dd);
            //Console.WriteLine(dd);
            //Console.WriteLine(d);
            ////本质上没有变
            ////Console.WriteLine("{0:0.00}",d);
            ////Console.WriteLine(d);
            //Console.ReadKey();
            #endregion



            #region //一.提示用户输入两个数字，计算这两个数字之间所有整数的和 综合练习
            //1.用户只能输入数字
            //2.要求第一个数字必须比第二个数字小  就重新输入
            //3.计算两个数字之间的和

            //Console.WriteLine("请输入第一个数字：");
            //string num1 = Console.ReadLine();
            //int numOne = GetInt(num1);
            //Console.WriteLine("请输入第二个数字");
            //string num2 = Console.ReadLine();
            //int numTwo = GetInt(num2);
            //Judge(ref numOne,ref numTwo);
            //int sum = Sum(numOne, numTwo);
            //Console.WriteLine(sum);
            //Console.ReadKey();
            #endregion

            #region //二.用一个方法实现：取出一组字符串中最长的那个元素
            //string[] names={"迈克尔乔丹","科比布莱恩特","勒布朗","蒂姆邓肯","奥尼尔","卡尔马龙"};
            //string[] names = { "迈克尔乔丹", "科比布莱恩特", "勒布朗", "蒂姆邓肯", "奥尼尔", "卡尔马龙" };
            //比较出最大的我们就要先假设一个最大的然后依次的去比较 谁最大max中就放谁
            //string max = names[0];
            ////你要清楚地知道 字符串就可以看成看成是一个字符型数组
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i].Length>max.Length)
            //    {
            //        max = names[i];
            //    }
            //}
            //Console.WriteLine(max);

            //string name = GetLongest(names);
            //Console.WriteLine(name);
            //Console.ReadKey();
            #endregion

            #region //三.写一个方法，用来判断用户输入的 是不是质数
            //再写一个方法，要求只能输入数字，输入有误就一直输入
            //Console.WriteLine("请输入一个数字:");
            //string strNumber = Console.ReadLine();
            //int number = PrintNum(strNumber);
            //bool b = IsPrime(number);
            //Console.WriteLine(b);
            //Console.ReadKey();
            #endregion

            #region //四.接收输入后判断其等级并打印出来
            //while (true)
            //{
            //    Console.WriteLine("请输入你的分数：");
            //    int score = Convert.ToInt32(Console.ReadLine());
            //    string level = GetLevel(score);
            //    Console.WriteLine(level);
            //    //Console.ReadKey();
            //}
            #endregion

            #region //五.将字符串反转string[] country={"中国","美国","日本","澳大利亚","巴西","加拿大","俄罗斯"};
            //string[] country = { "中国", "美国", "日本", "澳大利亚", "巴西", "加拿大", "俄罗斯" };
            //Rev(country);
            //for (int i = 0; i < country.Length; i++)
            //{
            //    Console.Write(country[i]+" ");
            //}
            //Console.ReadKey();
            #endregion

            #region //六.写一个方法 输入圆的半径 返回圆的半径和周长
            Console.WriteLine("请输入圆的半径：");
            double r = Convert.ToDouble(Console.ReadLine());
            double area;
            double per;
            GetAreaPer(r, out area, out per);
            Console.WriteLine(area);
            Console.WriteLine(per);
            Console.ReadKey();
            #endregion

            //方法三个练习03

        }

        #region 返回一个圆的面积和周长
        public static void GetAreaPer(double r, out double area, out double per)
        {
             area = 3.14 * r * r;
             per = 3.14 * 2 * r;
        }
        #endregion

        #region 五、反转方法
        public static void Rev(string[] arr)
        {
            //只需要交换arr.Length/2次       数组不需要有返回值  别的不行（以后详说）
            for (int i = 0; i < arr.Length/2; i++)
            {
                string tmp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = tmp;
            }
        }
        #endregion

        #region 四、判断等级方法
        public static string GetLevel(int score)
        {
            string level = "";
            switch (score/10)
            {
                case 10:level = "满分";break;
                case 9:level = "优秀";break;
                case 8:level = "优良";break;
                case 7:level = "一般";break;
                case 6:level = "较差";break;
                default:level = "不及格";
                    break;
            }
            return level;
        }
        #endregion

        #region 三、判断数字是否是质数 判断数字的合法性
        /// <summary>
        /// 判断一个数字是否为质数
        /// </summary>
        /// <param name="number">你要判断的数字</param>
        /// <returns></returns>
        public static bool IsPrime(int number)
        {
            if (number<2)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number%i==0)
                {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// 输入数字判断合法性
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        public static int PrintNum(string strNumber)
        {
            while (true)
            {
                try
                {
                    int num = Convert.ToInt32(strNumber);
                    return num;
                }
                catch
                {
                    Console.WriteLine("请重新输入");
                    strNumber = Console.ReadLine();
                }
            }
        }

        #endregion

        #region  二、找出一个字符串数组中的最长的元素
        /// <summary>
        /// 找出一个字符串数组中的最长的元素
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        public static string GetLongest(string[] names)
        {
            string max = names[0];
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length>max.Length)
                {
                    max = names[i];
                }
            }
            return max;
        }
        #endregion

        #region 一、综合；练习的三个方法
        /// <summary>
        /// 将字符串转为int类型 并判断其合法性
        /// </summary>
        /// <param name="s">输入的字符串类型的数字</param>
        /// <returns>返回转换后的数字</returns>
        public static int GetInt(string s)
        {
            while (true)
            {
                try
                {
                    int num = Convert.ToInt32(s);
                    return num;
                }
                catch
                {
                    Console.WriteLine("输入有误请重新输入！");
                    s = Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// 若第一个数字大于第二个数字重新输入 否则返回
        /// </summary>
        /// <param name="n1">输入的第一个数字</param>
        /// <param name="n2">输入的第二个数字</param>
        public static void Judge(ref int n1,ref int n2)
        {
            if (n1>n2)
            {
                Console.WriteLine("第一个数字要小于第二个数字,请重新输入第一个数字！");
                //重新输入需要先拿字符串类型接收
                string s1 = Console.ReadLine();
                //输入的字符串可能不能转为int类型 调用GetInt()方法
                n1 = GetInt(s1);
                Console.WriteLine("请输入第二个数字");
                string s2 = Console.ReadLine();
                n2 = GetInt(s2);
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// 求n1到n2之间所有整数的和
        /// </summary>
        /// <param name="n1">输入的第一个数字</param>
        /// <param name="n2">输入的第二个数字</param>
        /// <returns></returns>
        public static int Sum(int n1,int n2)
        {
            int sum = 0;
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
            return sum;
        }
        #endregion
    }
}
