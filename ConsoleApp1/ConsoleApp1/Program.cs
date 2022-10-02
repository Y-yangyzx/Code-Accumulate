using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一行代码
            //Console.WriteLine("Hellow world");
            //Console.ReadKey();

            //打好基础   非常非常重要
            //变量类型 变量名 = 赋值;
            //int a = 10;
            ////声明 赋值 使用
            //Console.WriteLine(a);
            //Console.ReadKey();



            //体会+连接字符串 输出
            //string name = "张三";
            //int age = 29;
            //char gender = '男';
            //string email = "zhangsan@qq.com";
            //string address = "张家街43号";
            //Console.WriteLine("我叫" + name + ",我今年" + age + ",我的性别" + gender + ",我的邮箱" + email + ",我的地址是" + address+"。");
            //Console.ReadKey();



            //体会变量重新赋值
            //int age = 18;
            //age = 81;
            //Console.WriteLine("原来你都" + age + "岁了。");
            //Console.ReadKey();


            //占位符输出
            //int n1 = 10;
            //int n2 = 20;
            //int n3 = 30;
            //Console.WriteLine("第一个数字是{1}，第二个数字是{2}，第三个数字是{0}。",n1,n2,n3);
            //Console.WriteLine("第一个数字是:"+n1+",第二个数字是："+n2+",第三个数字是："+n3);
            //Console.ReadKey();



            //法一：
            //交换两个变量
            //int n1 = 10;
            //int n2 = 20;
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;


            //法二：
            //n1 = n1 - n2; //-10    20
            //n2 = n1 + n2;//-10     10
            //n1 = n2 - n1;

            //Console.WriteLine("n1的值为{0},n2的值为{1}", n1, n2);
            //Console.ReadKey();





            //Console.WriteLine("请输入你的姓名：");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入你的年龄：");
            //string age = Console.ReadLine();
            //Console.WriteLine("请输入你的性别：");
            //string gender = Console.ReadLine();

            //Console.WriteLine("您的姓名是：{0}，您的年龄是：{1}，您的性别是：{2}", name, age, gender);
            //Console.ReadKey();


            //圆的半径是5  输出圆的面积和周长
            //int r = 5;
            //double S = 3.14 * r * r;
            //double C = 2 * 3.14 * r;
            //Console.WriteLine("圆的面积是：{0}，周长是{1}。",S,C);
            //Console.ReadLine();

            //int a = 10;
            //int b = 3;
            //double c = a*1.0 / b;
            //Console.WriteLine("{0:0.000}",c);
            //Console.ReadKey();




            //例子1：编程实现第几天（如46天）是第几周零几天

            //int date = 46;
            //int week = date / 7;
            //int day = date % 7;
            //Console.WriteLine("{0}天是第{1}周第{2}天",date,week,day);
            //Console.ReadKey();


            //例子2：编程实现107653秒是几天几小时几分钟几秒钟
            //思路：先求得几天 剩下秒数在计算几小时  再剩下描述计算几分钟  再剩下秒数
            //int sec = 107653;
            //int day = sec / 60 / 24 / 24;
            //int hour = sec / 60 / 24;
            //int min = sec / 60;
            //int s = min % 60;
            //Console.WriteLine("{0}秒是第{1}天，第{2}小时，第{3}分钟，第{4}秒",sec,day,hour,min,s);
            //Console.ReadKey();


            //***
            //int seconds = 107653;
            //int day = seconds / 86400;  //有多少天
            //int remainder = seconds % 86400;  //求完天数后剩余的秒数
            //int hour = remainder / 3600;  //用剩余的秒数计算有多少个小时
            //remainder = remainder % 3600;  //求完有多少个小时候剩余的秒数
            //int min = remainder / 60;  //剩余的秒数计算有多少分钟
            //remainder = remainder % 60;  //求完有多少分钟剩下的秒数
            //Console.WriteLine("{0}秒是第{1}天，第{2}小时，第{3}分钟，第{4}秒。",seconds,day,hour,min,remainder);
            //Console.ReadKey();





            //例子：输入姓名 然后分别输入语文、数学、英语成绩  输出姓名 总成绩  平均成绩
            //Console.WriteLine("请输入姓名：");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入语文成绩：");
            //string strChinese = Console.ReadLine();
            //Console.WriteLine("请输入数学成绩：");
            //string strMath = Console.ReadLine();
            //Console.WriteLine("请输入英语成绩：");
            //string strEnglish = Console.ReadLine();
            ////注意接收的是string类型 不兼容类型转换 用Convert
            //double Chinese = Convert.ToDouble(strChinese);
            //double Math = Convert.ToDouble(strMath);
            //double English = Convert.ToDouble(strEnglish);

            //Console.WriteLine("姓名：{0}，总成绩：{1}，平均成绩：{2}",name,Chinese+Math+English,(Chinese+Math+English)/3);



            //接收一个数字并向控制台输出它的2倍   （简写形式）
            //Console.WriteLine("请输入一个数字");
            ////string strnum = Console.ReadLine();
            ////double num = Convert.ToDouble(strnum);
            //double num = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(num*2);




            //利用逻辑运算符计算一个年份是否为闰年
            //Console.WriteLine("请输入一个年份：");
            //int year = Convert.ToInt32(Console.ReadLine());
            //bool b = (year % 400 == 0) || (year % 4 == 0 && year / 100 != 0);
            //Console.WriteLine(b);


            //分支结构  写一个例子
            //Console.WriteLine("请输入语文成绩：");
            //double chinese = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("请输入音乐 成绩：");
            //double music = Convert.ToDouble(Console.ReadLine());
            //if ((chinese >80 &&music >90) || (chinese==100 && music>70))
            //{
            //    Console.WriteLine("奖励100元");
            //}





            //多条件区间判断   用if-else实现
            //100-90 A
            //80-90 B
            //70-80 C
            //60-70 D
            //60以下 E

            //Console.WriteLine("请输入你的分数：");
            //double score = Convert.ToDouble(Console.ReadLine());
            //if (score>=90)
            //{
            //    Console.WriteLine("A");
            //}
            //else  //说明进入这个区间的score<90
            //{
            //    if (score>=80)//已经<90了  所以不用再写这个条件了
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else 
            //    {
            //        if (score>=70)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else
            //        {
            //            if (score>=60)
            //            {
            //                Console.WriteLine("D");
            //            }
            //            else
            //            {
            //                Console.WriteLine("E");
            //            }
            //        }
            //    }
            //}



            //用if else-if else 判断多条件区间
            //Console.WriteLine("请输入你的分数：");
            //double score= Convert.ToDouble(Console.ReadLine());
            //if (score>=90)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score>=80)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (score>=70)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (score>=60)
            //{
            //    Console.WriteLine("D");
            //}
            //else
            //{
            //    Console.WriteLine("E");
            //}



            //比价三个数字的大小  输出最大的数字
            //Console.WriteLine("请输入第一个数字：");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字：");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数字：");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            ////if (num1>num2&&num1>num3)
            ////{
            ////    Console.WriteLine(num1);
            ////}
            ////else if (num2>num1&&num2>num3)
            ////{
            ////    Console.WriteLine(num2);
            ////}
            ////else
            ////{
            ////    Console.WriteLine(num3);
            ////}

            //if (num1>num2)
            //{
            //    if (num1>num3)
            //    {
            //        Console.WriteLine(num1);
            //    }
            //    else
            //    {
            //        Console.WriteLine(num3);
            //    }
            //}
            //else
            //{
            //    if (num2>num3)
            //    {
            //        Console.WriteLine(num2);
            //    }
            //    else
            //    {
            //        Console.WriteLine(num3);
            //    }
            //}




            //例子：提示用户输入密码  如果密码为888888  则提示输入正确
            //否则提示输入错误再次输入  两次都输错结束程序！
            //首先判断几种情况  然后选择用哪个语句
            //Console.WriteLine("请输入密码：");
            //string pwd = Console.ReadLine();
            //if (pwd=="888888")
            //{
            //    Console.WriteLine("密码正确！");
            //}
            //else
            //{
            //    Console.WriteLine("密码错误，请重新输入！");
            //    pwd = Console.ReadLine();      //不需要在创建变量去接收了
            //    if (pwd=="888888")
            //    {
            //        Console.WriteLine("输入了第二次，密码正确！");
            //    }
            //    else
            //    {
            //        Console.WriteLine("输入了两次，仍然输入错误，程序结束！");
            //    }
            //}



            //提示输入用户名和密码  任何一个错了提示出来
            //首先判断几种情况
            //Console.WriteLine("请输入账号：");
            //string username = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //string pwd = Console.ReadLine();

            //if (username=="admin"&&pwd=="123456")
            //{
            //    Console.WriteLine("登录成功！");
            //}
            //else if(username=="admin")
            //{
            //    Console.WriteLine("密码输入错误！");
            //}
            //else if (pwd=="123456")
            //{
            //    Console.WriteLine("用户名输入错误！ ");
            //}
            //else
            //{
            //    Console.WriteLine("密码和用户名都输入错误！");
            //}





            //异常例子：输入一个字符串  将其转换为int类型
            //Console.WriteLine("请输入：");
            ////存在问题：一旦我输入的字符串无法转为int类型的话（123abc）那就会抛异常
            //bool b = true;
            //int s=0; //赋一个初值
            //try
            //{ 
            //     s = Convert.ToInt32(Console.ReadLine()); //赋值  这有可能赋一个非法值 

            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("输入字符串格式不正确");
            //    b = false;
            //}
            ////执行catch之后  会多输出来一个0  这是我们不想要的
            ////两种解决办法：1.将输出语句写在catch中
            ////2.引入一个bool类型的变量

            //if (b)
            //{
            //    Console.WriteLine(s * 2);
            //}




            //对李四工作进行年终评定
            //if else-if 写法
            //bool b = true;
            //Console.WriteLine("请输入李四的评定等级：");
            //string level = Console.ReadLine();
            //int salary = 5000;
            //if (level == "A")
            //{
            //   salary += 500;
            //}
            //else if (level=="B")
            //{
            //    salary += 200;
            //}
            //else if (level=="C")
            //{
            //    salary += 0;
            //}
            //else if (level =="D")
            //{
            //   salary -= 200;
            //}
            //else if (level == "E")
            //{
            //    salary -= 500;
            //}
            //else
            //{
            //    Console.WriteLine("输入有误，程序停止");
            //    b = false;
            //}
            //if (b)
            //{
            //    Console.WriteLine(salary);
            //}




            //switch  case 写法  处理多条件定值
            //bool b = true;
            //Console.WriteLine("请输入李四的评定等级：");
            //string level = Console.ReadLine();
            //int salary = 5000;
            //switch (level)
            //{
            //    case "A":
            //        salary += 500;
            //        break;
            //    case "B":
            //        salary += 200;
            //        break;
            //    case "C":
            //        break;
            //    case "D":
            //        salary -= 200;
            //        break;
            //    case "E":
            //        salary -= 500;
            //        break;
            //    default:
            //        Console.WriteLine("输入有误，程序停止。");
            //        b = false;
            //        break;
            //}
            //if (b)
            //{
            //    Console.WriteLine(salary);
            //}


            //对于结业考试的评价：
            //>=90   A
            //80-90  B
            //70-80  C
            //60-70  D
            //60以下 E

            //用switch-case 同样能够实现这样的效果  /10

            //bool b = true;
            //Console.WriteLine("请输入你的结业考试成绩");
            //int score=0;  //要给变量初始化
            //try
            //{
            //    score = Convert.ToInt32(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("输入不合法！");
            //    b = false;
            //}
            //if (b)
            //{

            //    switch (score / 10)
            //    {
            //        case 10:
            //        case 9:
            //            Console.WriteLine("A");
            //            break;
            //        case 8:
            //            Console.WriteLine("B");
            //            break;
            //        case 7:
            //            Console.WriteLine("C");
            //            break;
            //        case 6:
            //            Console.WriteLine("D");
            //            break;
            //        default:
            //            Console.WriteLine("E");
            //            break;
            //    }
            //}



            //请用户输入年份，再输入月份，然后输出这个月的天数（2月特殊）

            //想要程序做的异常少，需求分析少不了
            //需求1：可能出现异常的地方需要踹一下    try的范围
            //需求2：2月份需要判断是否为闰年 来决定输出的天数
            //需求3：输入月份只能是1-12月    用的if
            //bool b1 = true;
            //int year = 0;
            //Console.WriteLine("请输入年份:");           
            //try
            //{
            //    year = Convert.ToInt32(Console.ReadLine());
            //}
            //catch 
            //{
            //    Console.WriteLine("输入不合法，程序结束！");
            //    b1 = false;
            //}
            //if (b1)
            //{
            //    bool b2 = true;
            //    int month = 0;
            //    Console.WriteLine("请输入月份:");
            //    try
            //    {
            //       month = Convert.ToInt32(Console.ReadLine());
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入不合法，程序结束！");
            //        b2 = false;
            //    }

            //    if (b2)
            //    {
            //        switch (month)
            //        {
            //            case 1:
            //            case 3:
            //            case 5:
            //            case 7:
            //            case 8:
            //            case 10:
            //            case 12:
            //                Console.WriteLine($"{month}这个月的天数为31天");
            //                break;
            //            case 4:
            //            case 6:
            //            case 9:
            //            case 11:
            //                Console.WriteLine($"{month}这个月的天数是30天");
            //                break;
            //            case 2:
            //                if ((year % 400 == 0) || (year % 4 == 0 && year / 4 != 0))
            //                {
            //                    Console.WriteLine($"{year}这个年份{month}月的天数是29天");
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"{year}这个年份{month}月的天数是28天");
            //                }
            //                break;
            //            default:
            //                Console.WriteLine("输入的月份不在1-12月之间，程序结束！");
            //                break;
            //        }
            //    }

            //}

            //try的范围



            //请用户输入年份，再输入月份，然后输出这个月的天数（2月特殊）
            //Console.WriteLine("请输入年份");
            //try
            //{
            //    int year = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入如月份");
            //    try
            //    {
            //        int month = Convert.ToInt32(Console.ReadLine());
            //        int days = 0;
            //        if (month>=1&&month<=12)
            //        {
            //        switch (month)
            //        {
            //            case 1:
            //            case 3:
            //            case 5:
            //            case 7:
            //            case 8:
            //            case 10:
            //            case 12:
            //                days = 31;
            //                break;
            //            case 2:
            //                if ((year % 400 == 0) || (year % 4 == 0 && year / 4 != 0))
            //                {
            //                    days = 29;
            //                }
            //                else
            //                {
            //                    days = 28;
            //                }
            //                break;
            //            default:
            //                days = 30;
            //                break;
            //        }
            //        Console.WriteLine($"{year}年{month}月的天数是{days}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入月份不在1-12月之间！");
            //        }
            //    }
            //    catch {
            //        Console.WriteLine("输入月份有误！");
            //    }
            //}
            //catch {
            //    Console.WriteLine("输入年份有误！");
            //}




            //求1-100之间所有整数的和
            //把循环的次数加起来
            //循环体：一个一个相加    累加的过程
            //循环条件:i<=100    
            //int i = 1;
            //int sum = 0;
            //while (i<=100)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);




            //求1-100之间所有偶数的和
            //int i = 1;
            //int sum = 0;
            ////while (i<=100)
            ////{
            ////    if (i%2!=0)
            ////    {
            ////        sum += i;
            ////    }
            ////    i++;
            ////}
            ////Console.WriteLine(sum);
            //while (i <= 100)
            //{
            //    sum += i;
            //    i += 2;
            //}
            //Console.WriteLine(sum);



            //提示用户输入用户名和密码 只要其中一个错误就重新输入
            //利用while循环去做
            //string username = "";
            //string pwd = "";
            //while (username!="admin" || pwd!="888888")

            //while  ()中放的是关系表达式

            //{
            //    Console.WriteLine("请输入用户名：");
            //    username = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    pwd = Console.ReadLine();
            //}
            //Console.WriteLine("登陆成功！");




            //例子：输入班级人数 然后依次输入学员成绩 计算班级学员的平均成绩和总成绩
            //循环体：提示学员输入 接收学员的成绩
            //循环条件：小于等于班级人数
            // Console.WriteLine("请输入班级人数");
            // int count = Convert.ToInt32(Console.ReadLine());
            // int i = 1;
            //double sum = 0;
            // while (i<=count)
            // {
            //     Console.WriteLine($"请输入第{i}位学员的成绩：");
            //     double score = Convert.ToDouble(Console.ReadLine());
            //     sum  += score;
            //     i++;
            // }
            // Console.WriteLine($"班级人数为：{count}，总成绩为：{sum}，平均成绩为{sum/count}");








            //do-while循环例子：
            //小兰唱歌问老师满意么 满意放学 不满意不停的再唱一遍
            //Console.WriteLine("老师，我唱的你满意么？");
            //string answer = Console.ReadLine();
            //while (answer=="no")
            //{
            //    Console.WriteLine("老师，我唱了一遍您满意么？");
            //    answer = Console.ReadLine();
            //}
            //Console.WriteLine("放学回家！");

            //string answer = "";
            //do
            //{
            //    Console.WriteLine("老师，我唱的你满意么？");
            //    answer = Console.ReadLine();
            //} while (answer =="no");
            //Console.WriteLine("放学回家！");




            //提示用户输入用户名和密码 只要其中一个错误就重新输入
            //用do-while循环去做
            //string username = "";
            //string pwd = "";
            //do
            //{
            //    Console.WriteLine("请输入用户名：");
            //    username = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    pwd = Console.ReadLine();
            //} while (username!="admin" || pwd!="888888");
            //Console.WriteLine("登录成功！");




            //提示用户输入姓名，当输入q时停止
            //string name = "";
            //while (name !="q")
            //{
            //    Console.WriteLine("请输入姓名：");
            //    name = Console.ReadLine();
            //}
            //Console.WriteLine("程序停止！");




            //***要求用户不断输入数字 然后打印这个数字的二倍，当用户输入q时程序退出！！！
            //循环体：输入数字打 印数字二倍
            //循环条件：输入不为q

            //矛盾在于int和string两个类型的不同      看似很简单实际存在问题
            //所以说 纸上得来终觉浅，绝知此事要躬行！


            //string input = "";
            //while (input != "q")
            //{
            //    Console.WriteLine("请输入数字：");
            //    //int num = Convert.ToInt32(Console.ReadLine());  
            //    //输入的可能性：数字  q  其他  在这不能把input转为int类型  因为它有可能输入的是q或其他
            //    input = Console.ReadLine();
            //    if (input != "q")
            //    {
            //        try
            //        {
            //            int num = Convert.ToInt32(input);
            //            Console.WriteLine(num * 2);
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入不合法，请重新输入！");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("程序退出！");
            //    }
            //}





            //***要求用户不断输入数字 然后打印这个数字的二倍，当用户输入q时程序退出！！！
            //循环体：反复提示用户输入数字 然后转为int类型
            //循环条件：输入的不是q
            //string input = "";
            //while (input!="q")
            //{
            //    Console.WriteLine("请输入数字：");
            //    input = Console.ReadLine();
            //    if (input!="q")
            //    {
            //        int num = Convert.ToInt32(input);
            //        Console.WriteLine(num*2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("程序结束！");
            //    }
            //}









            //提示用户不停的输入数字 当用户输入end时 输出之前输入所有数的最大值
            //string input = "";
            //int max = 0;
            //while (input!="end")
            //{
            //    Console.WriteLine("请输入数字：");
            //    input = Console.ReadLine();
            //    if (input != "end") //输入的是数字
            //    {
            //        int num = Convert.ToInt32(input);
            //        if (num>max)
            //        {
            //            max = num;
            //        }                   
            //    }
            //    else //输入的是end
            //    {
            //        Console.WriteLine($"输入的最大值是：{max}");
            //    }
            //}



            //提示用户不停的输入数字 当用户输入end时 输出之前输入所有数的最大值
            //循环体：提示用户不停的输入数字    放在{}中
            //循环条件：输入不为end     放在()中
            //string input = "";
            //int max = 0;
            //while (input!="end")
            //{
            //    Console.WriteLine("请输入数字：");
            //    input = Console.ReadLine();//可能接收的是：数字  end  其他
            //    if (input != "end")
            //    {
            //        try
            //        {
            //            int num = Convert.ToInt32(input);
            //            max = max > num ? max : num;
            //        }
            //        catch 
            //        {
            //            Console.WriteLine("err");
            //            //break;
            //        }  
            //    }
            //    else  //输入的是end
            //    {
            //        Console.WriteLine($"之前输入最大值是：{max}");
            //    }

            //}




            //用while  continue实现计算1到100之间除了能被7整除之外所有数字的和
            //循环体：计算1-100之间的总和（有条件限制）
            //循环条件：<=100
            //int i = 0;
            //int sum = 0;
            //while (i<=100)
            //{
            //    if (i%7==0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);





            //***找出1-100之间的所有的素数
            //for (int i = 1; i < 100; i++)  //一个一个数字的遍历
            //{
            //    bool b = true;
            //    for (int j = 2; j < i; j++)  //筛选条件:在2到i-1之间还有没有能够被整除的数
            //    {
            //        if (i % j == 0)
            //        {
            //            b = false;
            //            break;
            //        }                     
            //    }
            //    if (b)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}




            //找到1-100之间所有的素数
            //for (int i = 1; i <= 100; i++)
            //{
            //    bool b = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i%j==0)
            //        {
            //            b = false;
            //            break;
            //        }
            //    }
            //    if (b)
            //    {
            //        Console.WriteLine("素数有{0}", i);
            //    }

            //}








            //找出100-999之间所有的水仙花数
            //水仙花数：首先他是一个三位数  百位数的立方+十位数的立方+个位数的立方==本身
            //例子：153
            //***百位：153/10   十位：153%100/10   个位：153%10
            //int count = 0;
            //for (int i = 100; i <= 999; i++)
            //{
            //    int b = i / 10;
            //    int s = i % 100 / 10;
            //    int g = i % 10;
            //    if (b * b * b + s * s * s+g * g * g == i)
            //    {

            //        Console.WriteLine($"水仙花数有{i}");
            //    }
            //}
            //Console.WriteLine("什么情况！");




            //九九乘法表
            //for (int i = 1; i <=9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write($"{i}*{j}={i*j}\t");
            //    }
            //    Console.WriteLine();
            //}




            //九九乘法表
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write($"{i}*{j}={i*j}\t");
            //    }
            //    Console.WriteLine();
            //}





            //截图例子：
            //Console.WriteLine("请输入一个数字：");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < number; i++)
            //{
            //    Console.WriteLine($"{i}+{number-i}={number}");
            //}




            //循环例子
            //循环录入5个人的年龄并计算平均年龄 如果录入的数据出现负数或大于100 报错并停止
            //int sum = 0;
            //bool b = true;
            //for (int i = 0; i < 5; i++)
            //{
            //    try
            //    {
            //        Console.WriteLine("请输入年龄：");
            //        int age = Convert.ToInt32(Console.ReadLine());
            //        if (age < 0 || age > 100)
            //        {
            //            Console.WriteLine("输入不合法，程序停止！");
            //            b = false;
            //            break;
            //        }
            //        else
            //        {
            //            sum += age;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入无法转为数字，程序停止！");
            //        b = false;
            //        break;
            //    }
            //}
            //if (b)
            //{
            //    Console.WriteLine("平均年龄是：{0}", sum / 5);
            //}








            //提示用户反复的输入用户名密码  直到正确直到为止
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名：");
            //    string username = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    string pwd = Console.ReadLine();

            //    if (username=="admin"&&pwd=="123456")
            //    {
            //        Console.WriteLine("登陆成功！");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("登录失败！");
            //    }
            //}




            //实现1-100相加  执行到总和大于20时 输出最后一个加数
            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum += i;
            //    if (sum>20)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}



            //产生随机数
            //Random ran = new Random();
            //while (true)
            //{
            //    int num = ran.Next(1, 11);
            //    Console.WriteLine(num);
            //}



            //随机产生一个人上辈子是做什么的
            //Random r = new Random();
            //while (true)
            //{
            //int num = r.Next(1, 7);//左开右闭 
            //Console.WriteLine("请输入姓名：");
            //string name = Console.ReadLine();
            //switch (num)
            //{
            //    case 1: Console.WriteLine("{0}上辈子是一坨翔", name);
            //        break;
            //    case 2: Console.WriteLine("{0}上辈子是吃翔的",name);
            //        break;
            //    case 3:
            //        Console.WriteLine("{0}上辈子是吃屎的", name);
            //        break;
            //    case 4:
            //        Console.WriteLine("{0}上辈子是吃shi的", name);
            //        break;
            //    case 5:
            //        Console.WriteLine("{0}上辈子是吃si的", name);
            //        break;
            //    case 6:
            //        Console.WriteLine("{0}上辈子是菩萨呀", name);
            //        break;
            //}
            //}






















































            Console.ReadKey();



        }
    }
}
