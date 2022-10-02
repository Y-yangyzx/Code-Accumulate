using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  //一、讲一个字符串实现倒序输出
            //方法一：倒序遍历字符串（char类型数组）
            //string str = "abcdefg";
            //string s = "";
            //for (int i = str.Length-1; i >=0; i--)
            //{
            //    s += str[i];  
            //}
            //str = s;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.Write(s[i]);
            //}

            //方法二：转为字符型数组收尾依次交换
            //string str = "abcdefgh";
            //将string类型字符串转换为char类型数组
            //char[] chs = str.ToCharArray();
            //for (int i = 0; i < chs.Length/2; i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length-1-i];
            //    chs[chs.Length-1-i] = temp;
            //}
            //将char类型数组转string类型的字符串
            //str = new string(chs);
            //Console.Write(str);
            //Console.ReadKey();
            #endregion


            //将Hello C sharp转为sharp C Hello
            
        }
    }
}
