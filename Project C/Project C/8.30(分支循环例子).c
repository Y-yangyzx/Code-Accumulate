#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
#include <windows.h>
#include <stdlib.h>
#include <time.h> 

//分支 循环 习题集合




//int main()
//{
	//例子1：求n的阶乘
		//int i = 0;  //初始化赋一个初值
		//int n = 0;//n最好是要自己输入
		//printf("请输入n的值：");
		//scanf("%d", &n);
		//int result = 1;  //不能初始化设为零  为1
		//for (i = 1; i < n+1; i++)
		//{
		//	result *= i;
		//}
		//printf("%d\n",result);
		//return 0;


//求n的阶乘（用循环语句书写） 第二遍
//int main()
//{
//	int n = 0;
//	int num = 1;
//	printf("请输入n的值：");
//	scanf("%d", &n);
//	for (int i = 1; i <= n; i++)
//	{
//		num *= i;
//	}
//	printf("%d\n", num);
//	return 0;
//}







	//例子2：求1！+ 2！+ 3！+ 4！+ 5！+ …… + n!
		//这道题目很重要  深入去理解for循环
		//int i = 0;
		//int n = 0;
		//int m = 0;
		//int ret = 1;
		//int sum = 0;
		//printf("请输入m的值：");
		//scanf("%d",&m);
		//for (n = 1; n <= m; n++)
		//{
		//	ret = 1;
		//	for (i = 1; i <= n; i++)
		//	{
		//		ret *= i;   //变量：被赋值之后就变了！！！一定要注意
		//	}
		//	sum  += ret;
		//}
		//printf("sum = %d\n",sum);



//方法一： 求1！+ 2！+ 3！+ 4！+ 5！+ …… + n!
//int main()
//{
//	int n = 3;
//	int num = 1;
//	int sum = 0;
//	for (int i = 1; i <= n; i++)
//	{
//		num *= i;
//		sum += num;
//	}
//	printf("%d\n",sum);
//	return 0;
//}



//方法二：利用双层循环实现这个需求
//int main()
//{
//	int m = 3;
//	int sum = 0;
//	for (int n = 1; n <= m; n++)
//	{
//		int ret = 1;
//		for (int i = 1; i <= n; i++)
//		{
//			ret *= i;
//		}
//		sum += ret;
//	}
//	printf("%d\n",sum);
//	return 0;
//}






	//例子3：查找数组中有没有某一个值
		//方法一：
		//int arr[] = { 1,2,3,4,5,6,7,8,9,10 };
		//int i = 0;
		//int k = 11;
		//int sz = sizeof(arr) / sizeof(arr[0]);
		//for (i = 0; i < sz; i++)
		//{
		//	if (arr[i] == k)
		//	{
		//		printf("找到了，下标是：%d\n",i);
		//		break;//找到了没必要再找了！
		//	}
		//}
		//if (i == sz)
		//{
		//	printf("找不到这个数！");
		//}


//遍历数组查找数组中有没有某值
//int main()
//{
//	int i = 0;
//	int n = 0;
//	printf("请输入你要查找的数字：");
//	scanf("%d",&n);
//	int arr[20] = {0,1,2,3,4,5,6,7,8,9};
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	for (i = 0; i < sz; i++)
//	{
//		if (arr[i]==n)
//		{
//			printf("%d\n",i);
//			break;
//		}
//	}
//	if (i==sz)
//	{
//		printf("%d\n",-1);
//	}
//	return 0;
//}



		//方法二：二分查找法
		//int arr[] = {1,2,3,4,5,6,7,8,9,10};
		//int k = 7;
		//int left = 0;
		//int right = (sizeof(arr) / sizeof(arr[0]))-1;
		//
		//while (left <= right)
		//{
		//	int mid = (left + right) / 2;
		//	//得放在while循环中
		//	if (arr[mid] > k)
		//	{
		//		right = mid - 1;
		//	}
		//	else if (arr[mid] < k)
		//	{
		//		left = mid + 1;
		//	}
		//	else
		//	{
		//		printf("找到了，下标是：%d\n", mid);
		//		break;
		//	}
		//}
		//if (left>right)
		//{
		//	printf("找不到！");
		//}



//二分查找法 在数组中查找数字
//int main()
//{
//	int n = 0;
//	int i = 0;
//	int arr[20] = { 1,2,3,4,5,6,7,8,9,10 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	int left = 0;
//	int right = sz - 1;
//	printf("请输入要查找的数字：");
//	scanf("%d",&n);
//	while (left<=right)
//	{
//		int mid = (left + right) / 2;
//		if (arr[mid]>n)
//		{
//			right = mid - 1;
//		}
//		else if(arr[mid]<n)
//		{
//			left = mid + 1;
//		}
//		else
//		{
//			printf("%d\n",mid);
//			break;
//		}
//	}
//	if (left>right)
//	{
//		printf("不存在要查找的数字");
//	}
//	return 0;
//}


	//例子4：welcome to bit !!!!!
		   //####################
		//char str1[] = "welcome to bit !!!!!";
		//char str2[] = "####################";
		//int left = 0;
		//int right = sizeof(str1)/sizeof(str1[0])-2;
		//while (left<=right)
		//{
		//	str2[left] = str1[left];
		//	str2[right] = str1[right];
		//	printf("%s\n", str2);
		//	Sleep(1000);
		//	system("cls");
		//	left++;
		//	right--;
		//}
		//printf("%s\n",str2);






 //welcome to bit !!!!!
 //####################
//int main()
//{
//	char str1[] = "welcome to bit !!!!!";
//	char str2[] = "####################";
//	int sz = sizeof(str1) / sizeof(str1[0]);
//	int left = 0;
//	int right = sz - 2; //计算sz的时候算了一个'\n' 所以要减去2！！！
//	//char类型的数组要注意字符串结束标志
//	for (int i = 0; i < sz; i++)
//	{
//		if (left<=right)
//		{
//			str2[left] = str1[left];
//			left++;
//			str2[right] = str1[right];
//			right--;
//			printf("%s\n",str2);  //注意输出  在每循环一次就输出一次
          //两个函数  记住他们的用法以及要引用的头文件
//			Sleep(1000);
//			system("cls");
//		}
//		else
//		{
//			break;
//		}
//	}
//	printf("%s\n",str2);
//	return 0;
//}




//例子5：模拟登录情景，且只能登录三次
//int main()
//{
//    char pwd[20] = { 0 };
//    int i = 0;
//    for (i = 0; i < 3; i++)
//    {
//	    printf("请输入登录密码：");
//	    scanf("%s", pwd);
//	    if (strcmp(pwd, "123456") == 0)
//	    {
//		   printf("登录成功！");
//	       break;
//	    }
//	    else
//	    {
//		  printf("密码有误！");
//	    }
//    }
//     if (i == 3)
//     {
//	   printf("禁止输入！");
//     }
//   return 0;
//}




//模拟登录情景，且只能登录三次
//int main()
//{
//	int i = 0;
//	char pwd[20] = {0};	
//	for ( i = 0; i < 3; i++)
//	{
//		printf("请输入密码：");
//		scanf("%s", &pwd);
//		if (strcmp(pwd,"admin")==0)  //字符串判断相等是字母字符串可以==  但是是数字字符串不行
//		{
//			printf("登录成功！");
//			break;
//		}
//		else
//		{
//			if (i<2)
//			printf("密码错误，请重新输入！\n");
//		}
//	}
//	if (i==3)
//	{
//		printf("登录次数已超过三次，程序退出！\n");
//	}
//	return 0;
//}





//int main()
//{
//习题例子1：三个数倒序输出
	//a b c
	//int a = 0;
	//int b = 0;
	//int c = 0;
	//int temp = 0;
	//printf("请分别输入a,b,c的值");
	//scanf("%d %d %d",&a,&b,&c);
	////算法实现：把最大的值放在a中 b次之 c最小
	////          引入一个temp变量
	//if (a<b)
	//{
	//	temp = a;
	//	a = b;
	//	b = temp;
	//}
	//if (a<c)
	//{
	//	temp = a;
	//	a = c;
	//	c = temp;
	//}
	//if (b<c)
	//{
	//	temp = b;
	//	b = c;
	//	c = temp;
	//}
	//printf("三个字母倒序排列为：%d %d %d",a,b,c);



//实现三个数倒序输出
//实现思路:三个变量：a、b、c a中存放最大值 b中存放次之 c中存放最小值
//int main()
//{
//	int a, b, c=0;
//	int temp = 0;
//	printf("请分别输入三个数的值：");
//	scanf("%d%d%d", &a,&b,&c);
//	if (a<b)
//	{
//		temp = b;
//		b = a;
//		a = temp;
//	}
//	if (a<c)
//	{
//		temp = c;
//		c = a;
//		a = temp;
//	}
//	if (b<c)
//	{
//		temp = c;
//		c = b;
//		b = temp;
//	}
//	printf("三个数倒序排序的结果是：%d %d %d",a,b,c);
//	return 0;
//}



  //补充：三个数字比出最大值
	//int a = 0;
	//int b = 0;
	//int c = 0;
	//printf("请分别输入abc的值：");
	//scanf("%d %d %d",&a,&b,&c); //%d之间打上一个 否则可能报错
	//                            //报错的提示很不好（非真正的错误原因）
	//if (a>b)
	//{
	//	if (a>c)
	//	{
	//		printf("最大值为：%d\n",a);
	//	}
	//	else
	//	{
	//		printf("最大值为：%d\n", c);
	//	}
	//}
	//else
	//{
	//	if (b>c)
	//	{
	//		printf("最大值为：%d\n", b);
	//	}
	//	else
	//	{
	//		printf("最大值为：%d\n", c);
	//	}
	//}




//打印一个九九乘法表
//int main()
//{
//	int num = 0;
//	char arr[]={0};
//	for (int i = 1; i <= 9; i++)
//	{
//		for (int j = 1; j <= i; j++)
//		{
//			num = i * j;
//			printf("%d * %d = %d ",j,i,num);			
//		}
//		printf("\n");
//	}
//	return 0;
//}



//习题例子2：打印出100以内3的倍数
	//算法实现思路：打印1-100的所有数字  每一个数字%3 == 0 即为3的倍数
	//int i = 0;
	//int count = 1;
	//for (i = 1; i <= 100; i++)
	//{
	//	if (i%3 == 0)
	//	{
	//		printf("%d %d\n",i,count);
	//		count++;
	//	}
	//}



//习题例子3：求两个数的最大公约数
	//思路：m=24  n=18   r=m%n   m=n  n=r  继续：m%n  直到m%n==0 r就是最大公约数
	//这个思路 逻辑 你需要理解！  辗转相除法！！！
//int main()
//{
//	int m = 0;
//	int n = 0;
//	int r = 0;
//	printf("请分别输入m,n的值：");
//	scanf("%d %d", &m, &n);
//	while (r = m % n)
//	{
//		/*r = m % n;*/
//		m = n;
//		n = r;
//	}
//	printf("最大公约数是：%d\n", n);
//
//}




//求两个数的最大公约数
//思路：m = 24  n = 18   r = m % n   m = n  n = r  继续：m%n  直到m%n == 0 r就是最大公约数
//int main()
//{
//	int m = 35;
//	int n = 35;
//	int r = 0;
//	while (r = m % n)
//	{
//		r = m % n;
//		m = n;
//		n = r;
//	}
//	printf("最大公约数是：%d", n);
//	
//	return 0;
//}




//习题例子4：打印1000-2000年之间的闰年
	//1.能被4整除但不能被100整除
	//2.能被400整除
	//int i = 0;
	//int count = 1;
	//for (size_t i = 1000; i <= 2000; i++)
	//{
	//	if ((i%4==0&&i%100!=0) ||i%400==0)
	//	{
	//		printf("%d %d\n",i,count);
	//		count++;
	//	}
	//}


//习题例子5：打印100-200之间的素数  重点  优化再优化
	//思路：素数 只能被1和自己整除的数  试除法 2 -> i-1
//	int i = 0;
//	int count = 1;
//	for ( i = 100; i <= 200; i++)
//	{
//		int j = 0;
//		for ( j = 2; j < i; j++)
//		{
//			if (i%j==0)
//			{
//				break;
//			}	
//		}
//		if (j == i)
//		{
//			printf("%d %d\n", i,count);
//			count++;
//		}
//	}
//	return 0;
//}



//打印100-200之间的素数  重点  优化再优化
//试除法 2--->i-1

//简化两步：1.偶数不可能是素数
          //2.开平方
//int main()
//{
//	int count = 0;
//	for (int i = 101; i < 200; i+=2)
//	{
//		int j = 0;
//		for (j = 2; j < sqrt(i); j++)
//		{
//			if (i%j==0)
//			{
//				break;
//			}
//		}
//		if (j==i)
//		{
//			count++;
//			printf("%d %d\n",i,count);
//		}
//	}
//
//}









//猜数字游戏
//void menu()
//{
//	printf("***********************\n");
//	printf("*****1.game 0.exit*****\n");
//	printf("***********************\n");
//}
//void game() 
//{
//	//1.先产生一个随机数
//	int ret = 0;
//	int guess = 0;
//	ret = rand()%100+1;
//	//printf("%d\n",ret);
//    //2.判断随机数与所猜数字大小
//	while (1)
//	{
//		printf("请输入要猜的数字：");
//		scanf("%d", &guess);
//		if (guess > ret)
//		{
//			printf("猜大了");
//		}
//		else if (guess < ret)
//		{
//			printf("猜小了");
//		}
//		else
//		{
//			printf("恭喜你,猜对了");
//			break;
//		}
//	}	
//}
//int main()
//{
//////例子：猜数字游戏
////	//生成随机数
////	//猜数字  反复的玩儿
//	int input = 0;
//	//产生随机数的起点
//	srand((unsigned int)time(NULL));
//	while (1)
//	{
//		menu();
//		printf("请选择：>");
//		scanf("%d", &input);
//		if (input == 1)
//		{
//			game();
//		}
//		else if (input == 0)
//		{
//			printf("游戏退出！");
//			break;
//		}
//		else
//		{
//			printf("输入错误，请重新输入！\n");
//		}
//	}
//
//	return 0;
//}






////猜数字游戏
//void menu()
//{
//	printf("*****************************\n");
//	printf("********1.game 0.exit********\n");
//	printf("*****************************\n");
//}
//
//void game()
//{
//	int r = 0;
//	int guess = 0;
//	//1.首先产生一个随机数
//	//2.自己输入一个数字与随机数比较大小
//	r = rand()%100+1;
//	//printf("%d\n", r);	
//	while (1)
//	{
//		printf("请输入你要猜测的数字：");
//		scanf("%d", &guess);
//		//注意逻辑问题
//		if (guess>r)
//		{
//			printf("猜大了");
//		}
//		else if (guess<r)
//		{
//			printf("猜小了");
//		}
//		else
//		{
//			printf("恭喜你,猜对了");
//			break;
//		}
//	}
//}
//int main()
//{
//	int n = 0;
//	srand((unsigned int)time(NULL));
//	
//	while (1)
//	{
//		//这个放的位置很重要
//		menu();
//		printf("请选择：");
//		scanf("%d", &n);
//		if (n==1)
//		{
//			game();
//		}
//		else if (n==0)
//		{
//			printf("游戏退出！");
//			break;
//		}
//		else
//		{
//			printf("输入错误请重新输入！\n");
//		}
//	}
//	return 0;
//}








//关机程序
//int main()
//{
//	//关机命令 shutdown -s -t 60
//	  char input[20] = { 0 };
//	  system("shutdown -s -t 60");
//again:
//	printf("你的电脑将在一分钟之内关闭，输入我是猪取消命令\n请输入：");
//	scanf("%s",input);
//	if (strcmp(input,"我是猪")==0)  //比较两个字符串是否相等
//	{
//		//system("shutdown -a");
//		printf("命令已取消！");
//	}
//	else
//	{
//		printf("未取消命令！\n");
//		goto again;
//	}
//	return 0;
//}


//int main()
//{
//	char input[20] = { 0 };  //字符串
//	//system("shutdown -s -t 60");
//	while (1)
//	{
//		printf("你的电脑将在1分钟内关闭，输入我是猪取消命令\n请输入：");
//		scanf("%s", &input);                 //输入字符串
//		if (strcmp(input, "我是猪") == 0)    //字符串比较是否相等的方法strcmp
//		{
//			//system("shutdown -a");
//			printf("命令已取消");
//			break;
//		}
//		else
//		{
//			printf("命令未取消,请重新输入！");
//		}
//	}
//	return 0;
//}