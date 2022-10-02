#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <windows.h>
#include <stdlib.h>
#include <math.h>
//温故而知新
//例题：求100-200之间的素数   -> 试除法  2 -> i-1
 //简化1：偶数一定不是素数
 //简化2：如果还有可以被整除的数（2个是一对儿），其中较小的那个数一定
       //小于等于被开方数
       //100 = 2*50 10*10 sqrt(100)=10
//int main()
//{
//	int i = 0;
//	int count = 1;
//	for (i = 101; i < 200; i+=2)
//	{
//		int j = 0;
//		for ( j = 2; j <= sqrt(i); j++)
//		{
//			if (i%j == 0)
//			{
//				break;
//			}
//		}
//		if (j > sqrt(i))   //注意也要修改
//		{
//			printf("%d %d\n",i,count);
//			count++;
//		}
//	}
//	return 0;
//}




//例题：求两个数的最大公约数
  //思路：r=m%n循环判断 当r=0时循环条件就不成立了，输出n的值就是最大公约数
  //辗转相除法
  //int main()
//{
//	int a = 0;
//	int b = 0;
//	int r = 0; //r是取余的余数
//	printf("请输入两个数字：");
//	scanf("%d %d",&a,&b);
//	while (r = a%b)
//	{
//		a = b;
//		b = r;
//	}
//	printf("最大公约数是：%d\n",b);
//	return 0;
//}




//例子：三个数倒序输出   a b c
  //思路：让a中存放最大值  b中存放第二大值  c中存放最小值
        //想要实现需要引入一个变量temp
//int main()
//{
//	int a = 0; 
//	int b = 0;
//	int c = 0;
//	int temp = 0;
//	printf("请分别输入a,b,c的值：");
//	scanf("%d %d %d",&a,&b,&c);
//	if (a<b)
//	{
//		temp = a;
//		a = b;
//		b = temp;
//	}
//	if (a<c)
//	{
//		temp = a;
//		a = c;
//		c = temp;
//	}
//	if (b<c)
//	{
//		temp = b;
//		b = c;
//		c = temp;
//	}
//	printf("倒序输出顺序为：%d %d %d",a,b,c);
//	return 0;
//}




//例1：求n的阶乘
  //思路：利用i变量的变化 乘起来
//int main()
//{
//	int i = 0;
//	int n = 0;
//	int Factorial = 1;
//	printf("请输入n的值：");
//	scanf("%d",&n);   //scanf("请输入n的值：%d", &n);这种写法无效
//	for (i = 1; i <= n; i++)
//	{
//		Factorial *= i;
//	}
//	printf("n的阶乘结果是：%d\n",Factorial);
//	return 0;
//}




//例子：求1！+ 2！+ 3！+ 4！+ 5！+ …… + n!
//int main()
//{
//方法一：
//	int i = 0;
//	int j = 0;
//	int n = 0;	
//	int sum = 0;
//	printf("请输入n的值：");
//	scanf("%d",&n);
//	for (i = 1; i <= n; i++)
//	{
//		int Factorial = 1;
//		for (j = 1; j <= i; j++)
//		{
//			Factorial *= j;
//		}
//		sum += Factorial;
//	}
//	printf("结果是：%d\n",sum);


//方法二：简化版 
//	int i = 0;
//	int n = 0;
//	int Factorial = 1;
//  int sum =0;
//	printf("请输入n的值：");
//	scanf("%d",&n);   
//	for (i = 1; i <= n; i++)
//	{
//		Factorial *= i;
//		//n!中包含1! 2! 3！……n! 一个一个的算 每算出一个就加在sum中
//      sum += Factorial;
//	}
//	printf("结果是：%d\n", sum);
//	return 0;
//}




//例3：查找数组中有没有某一个值
//思路：笨方法：遍历数组一个个找
//int main()
//{
//	int i = 0;
//	int num = 0;
//	int arr[] = { 1,2,3,4,5 };
//	int length = sizeof(arr) / sizeof(arr[0]);
//	printf("请输入要查找的值：");
//	scanf("%d",&num);
//	for (i = 0; i < length; i++)
//	{
//		if (i == num)
//		{
//			printf("%d\n",i);
//			break;
//		}
//	}
//	if (i==length)
//	{
//		printf("数组中没有此值！");
//	}
//	return 0; 
//}


//二分查找法：
  //思路：left 左值  right 右值
//int main()
//{
//	int n = 0;
//	int i = 0;
//	int arr[] = { 1,2,3,4,5,6,7,8 };
//	int length = sizeof(arr) / sizeof(arr[0]);
//	int left = 0;
//	int right = length-1;
//	
//	printf("输入要查找的值：");
//	scanf("%d",&n);
//	while (left<=right)
//	{
//		int mid = (left + right) / 2;
//		//这个mid要每次随着二分的变化而变化！！！
//		if (arr[mid]>n)   //arr[mid]这个数>n
//		{
//			right = mid - 1;
//		}
//		else if (arr[mid]<n)
//		{
//			left = mid + 1;
//		}
//		else
//		{
//			printf("%d\n",arr[mid]);
//			break;
//		}
//	}
//	if (left > right)
//	{
//		printf("数组中不存在n的值！");
//	}

//	return 0;
//}




////例4：welcome to bit !!!!!
//     //####################
//int main()
//{
//	char arr1[] = "welcome to bit !!!!!";
//	char arr2[] = "####################";
//	int left = 0;
//	int right = sizeof(arr1) / sizeof(arr1[0]) - 2;  //有一个字符串结束标志
//	//占字符空间  但是不算字符长度里
//	//int right = strlen(arr1) - 1;
//	while (left<=right)
//	{
//		arr2[left] = arr1[left];
//		arr2[right] = arr1[right];
//		printf("%s\n", arr2);
//		Sleep(1000);
//		system("cls	");
//		left++;
//		right--;		
//	}
//	printf("%s\n", arr2);
//	return 0;
//}




//例子5：模拟登录情景，且只能登录三次
  //思路：输入密码 判断是否正确 三次错误提示三次密码输入均错误，退出程序！
//int main()
//{
//	//int i = 0;
//	//char pwd[20] = { 0 };
//	//for (i = 0; i < 3; i++)
//	//{
//	//	//代码放的位置很有讲究！！！！！！！！！！  
//	//	//属于逻辑错误！
//	//	printf("请输入密码："); 
//	//	scanf("%s", &pwd);
//	//	//判断两个字符串是否相等 用库函数：strcmp
//	//	if (strcmp(pwd,"123456")==0)
//	//	{
//	//		printf("登录成功！");
//	//		break;
//	//	}
//	//	else
//	//	{
//	//		printf("登录失败！\n");
//	//	}
//	//}
//	//if (i==3)
//	//{
//	//	printf("三次密码输入均错误，退出程序！");
//	//}
//	//return 0;
//
//
//	
//	//再写一遍
//	int i = 0;
//	char pwd[20] = {0};
//	for ( i = 0; i < 3; i++)
//	{
//	    //输错了反复的输  所以放在这里
//		printf("请输入密码：");
//		scanf("%s", pwd);
//		if (strcmp(pwd,"123456")==0)
//		{
//			printf("登陆成功！");
//			break;
//		}
//		else
//		{
//			if (i==2)
//			{
//				//特别的好!
//			}
//			else
//				printf("登录失败!\n");
//		}
//	}
//	if (i==3)
//	{
//		printf("三次密码输入均错误，退出程序！");
//	}
//}




//函数
//创建一个自定义函数get_max() 返回两个数中的最大值
//int get_max(int x,int y) 
//{
//	if (x > y)
//	{
//		return x;
//	}
//	else
//		return y;
//}
//int main()
//{
//	int a = 10;
//	int b = 30;
//	int max = get_max(a,b);
//	printf("max=%d\n",max);
//	max = get_max(100,500);
//	printf("max=%d\n", max); 
//	return 0;
//}



//*例：交换两个变量的值 Swap1  Swap2
void Swap1(int x,int y)
{
	int temp = 0;
	temp = x;
	x = y;
	y = temp;
}
//void Swap2(int* x,int* y)
//{
//	int temp = 0;
//	temp = *x;
//	*x = *y;
//	*y = temp;
//}
//void Swap2(int*  x, int* y)
//{
//	int temp = 0;
//	temp = *x;
//	*x = *y;
//	*y = temp;
//}
//int main()
//{
//	int a = 10;
//	int b = 30;
//	Swap1(a,b);
//	printf("%d %d\n",a,b);
//	Swap2(&a,&b);
//	printf("%d %d\n",a,b);
//	return 0;
//}



//例：用函数的方式判断一个数是否为素数
//int is_prime(int n)
//{
//	//下边用了i 在这里用j变量  否则可能会产生错误
//	int j = 0;
//	for (j = 2; j <=sqrt(n); j++)
//	{
//		if (n%j==0)
//			return 0;  //它一执行 整个函数都结束了！   break只是跳出循环
//	}
//	/*if (i==n)
//	{*/
//     return 1;  //只有这一种可能了 所以不用再写if了
//	/*}*/
//}
//int main()
//{
//	int i = 0;
//	for (i = 100; i <= 200; i++)
//	{
//		if (is_prime(i)==1)
//		{
//			printf("%d\n",i);
//		}
//	}
//	return 0;
//}



//例：用函数实现查找出1000-2000年之间的闰年
//int is_Run(int n)
//{
//	if ((n%4==0 && n%100!=0) || (n%400==0))
//	{
//		return 1;
//	}
//	return 0;
//}
//int main()
//{
//	int i = 0;
//	for ( i = 1000; i < 2000; i++)
//	{
//		if (is_Run(i)==1)
//		{
//			printf("%d ",i);
//		}
//	}
//	return 0;
//}




//例：用函数实现整型数组二分查找
    //如果找到了返回这个值的下标 如果找不到返回-1
//int search(char arr[],int n,int sz)
//{
//	int left = 0;
//	int right = sz - 1;
//	while(left<=right)
//	{
//		int mid = (left + right) / 2;  //!!!!!!!!!!!!!!!!!
//		if (n < arr[mid])
//		{
//			right = mid - 1;
//		}
//		else if (n > arr[mid])
//		{
//			left = mid + 1;
//		}
//		else
//		{
//			return mid;
//		}
//	}
//		return -1;
//}
//int main()
//{
//	int n = 0;
//	char arr[] = { 1,2,3,4,5,6,7,8,9,10 };
//	printf("请输入要查找的数字：");
//	scanf("%d",&n);
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	int ret = search(arr, n, sz);
//	printf("%d\n", ret);	
//	return 0;
//}



//重写
//int search(int arr[],int k,int sz) //实现功能需要用到什么值就传入什么参数
//{
//	int left = 0;
//	int right = sz-1;
//	while (left<=right)
//	{
//		int mid = (left + right) / 2;
//		if (arr[mid]>k) 
//		{
//			right = mid - 1;
//		}
//		else if (arr[mid]<k)
//		{
//			left = mid + 1;
//		}
//		else
//		{
//			return mid;
//		}
//	}
//	return -1;
//}

//int main()
//{
//	int k = 0;
//	int arr[] = { 0,1,2,3,4,5,6,7,8,9 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	printf("请输入要查找的k的值：");
//	scanf("%d",&k);
//	int ret = search(arr,k,sz);
//	printf("%d\n",ret);
//	return 0;
//}







//例：写一个函数，每调用一次num就加1
//void function(int* n)  //改变num的值  传地址近来！
//{
//	(*n)++;	
//	//无返回值 不用写int了呗
//}
//int main()
//{
//	int num = 0;
//	function(&num);
//	printf("%d\n",num);
//	function(&num);
//	printf("%d\n", num);
//	function(&num);
//	printf("%d\n", num);
//	function(&num);
//	printf("%d\n", num);
//	return 0;
//}





//***递归



//接收一个整形值（无符号），按照顺序打印他的每一位 
//例 输入：1234   输出：1 2 3 4
//void print(int x)
//{
//	if (x>9)
//	{
//		print(x / 10);  //返回值是商几
//	}
//	printf("%d ",x%10);  //返回值是余几
//}
//int main()
//{
//	int num = 0;
//	printf("请输入num的值：");
//	scanf("%d",&num);
//	print(num);
//	/*printf("%d\n", num);*/
//	return 0;
//}



//例：编写函数，求字符串长度  不创建临时变量
//strlen库函数   bit\0  一个个判断是否为\0
//方法1：引入临时变量
//int my_strlen(char* str)
//{
//	int count = 0;  //临时变量
//	while(*str != '\0')
//	{
//		count++;
//		str++;
//	}
//	return count;
//}
//

//方法2：递归思想去做
//int my_strlen(char* str)
//{
//	if (*str != '\0')
//	{
//		return 1 + my_stlen(str+1); //递归思想
//	}
//	else
//	{
//		return 0;
//	}
//}
//
//int main()
//{
//	char arr[] = "bit";
//	int len = my_strlen(arr);
//	printf("%d\n",len);
//	return 0;
//}




//递归和迭代
//例：求n的阶乘
//int Fac(int n)
//{
//	if (n<=1)
//	{
//		return 1;
//	}
//	else
//	{
//		return n * Fac(n-1);
//	}
//}
//int main()
//{
//	int n = 0;
//	scanf("%d",&n);
//	int ret = Fac(n);
//	printf("%d\n",ret);
//	return 0;
//}




//斐波那契数列
//递归方式   缺点：效率太低  重复次数太多！
//int Fib(int n)
//{
//	if (n<=2)
//	{
//		return 1;
//	}
//	else
//	{
//		return Fib(n - 1) + Fib(n - 2);
//	}
//}

//循环方式  合适
//int Fib(int n)
//{
//	int a = 1;
//	int b = 1;
//	int c = 1;
//	while (n>2)
//	{
//		c = a + b;
//		a = b;
//		b = c;
//		n--;
//	}
//	return c;
//}
//
//int main()
//{
//	int n = 0;
//	printf("请输入要求第几个斐波那契数：");
//	scanf("%d",&n);
//	int ret =  Fib(n);
//	printf("%d\n",ret);
//	return 0;
//}



//递归经典案例
//例1：汉诺塔

//int main()
//{
	// 判断条件被省略---恒为正   死循环
	//for (;;)
	//{
	//	printf("hehe\n");
	//}



	//换汤不换药
	//int x, y;
	//for ( x = 0,y=0; x < 2 && y < 5; x++,++y)
	//{
	//	printf("hehe\n");
	//}




	//输出1234且未结束
	/*int i =1;
	do
	{
		if (i == 5)
			continue;
			printf("%d",i);
			i++;
	} while (i<=10);*/
	//return 0;
//}
//例2：青蛙跳台阶
