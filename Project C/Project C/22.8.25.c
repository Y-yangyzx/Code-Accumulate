#define _CRT_SECURE_NO_WARNINGS

//别人的东西 打招呼
//#include <stdio.h>



//int main()  //主函数---函数的入口
//{
//	/*printf("hello world\n");*/
//	//printf("这是我的第二个C语言程序！\n");
//	/*char ch;
//	ch = 'a';
//	printf("%c\n", ch);
//
//	short int num = 99;
//	printf("%d\n", num);*/
//
//	//输出大小是字节数
//	printf("%d\n", sizeof(int));
//	printf("%d\n", sizeof(float));
//	printf("%d\n", sizeof(short));
//	return 0;
//}


//int main()
//{
//	int num1 = 0;
//	int num2 = 0;
//	int sum = 0;
//	scanf("%d%d", &num1, &num2);
//	sum = num1 + num2;
//	printf("sum = %d\n", sum);
//	return 0;
//}


//#include <stdio.h>

#define MAX 10 //注意在结尾不要写分号  定义标识符常量
//int main()
//{
//	printf("%d\n", MAX);
//	return 0;
//}


//枚举---一一列举   关键字：enum

//enum Color
//{
//	red,
//	yellow,
//	green
//};
//int main()
//{
//	/*enum Color color = yellow;
//
//	enum Color color2 = green;
//	printf("%d\n%d\n",color,color2); */  //自我尝试输出多个变量  尝试
//	/*printf("%s\n", color);*/
//
//	char arr1[] = "abc";   //结尾包含一个'\0'
//	char arr2[] = { 'a','b','c','\0'};  //要在结尾加上一个'\0'，它不算在字符串长度中
//	printf("%s\n",arr1);
//	printf("%s\n", arr2);
//	return 0;
//}



//利用函数求最大值
//int Max(int a,int b)
//{
//	if (a>b)
//	{
//		return a;
//	}
//	else
//	{
//		return b;
//	}
//}
//int main()
//{
//	int num1 = 10;
//	int num2 = 20;
//	int max = Max(num1, num2);
//	printf("%d\n", max);
//	return 0;
//}


//int main()
//{
//	int arr[10] = {1,2,3,4,5,6,7,8,9,10};
//	int i = 0;
//	while (i< 10)
//	{
//		printf("%d\n", arr[i]);
//		i++;
//	}
//	/*printf("%d\n", arr[9]);*/
//	return 0;
//}


//&:按位与  |:按位或  ^:按位异或
//先转换为2进制
//int main()
//{
//	//int a = 7;
//	//int b = 5;
//	//int c = a & b;
//	////011          111
//	////101          101
//	////001 输出1    101   输出5
//	//printf("%d\n", c);
//
//	int a = 9;
//	printf("%d\n", a);
//	printf("%d\n", !a);  //单目操作符：数字为不为0   输出0   为0  输出1
//	return 0;
//
//}

//函数的方式
//int Max(int x, int y)
//{
//	if (x>y)
//	{
//		return x;
//	}
//	else
//	{
//		return y;
//	}
//}

//定义宏
//#define MXY(X,Y) (X>Y?X:Y)
//int main()
//{
//	int a = 20;
//	int b = 30;
//	int max = Max(a, b);
//	printf("%d\n",max );
//	max = MXY(a, b);
//	printf("%d\n", max);
//	return 0;
//}

#include <stdio.h>
//结构体
	//创建结构体
//struct Person
//{
//	char name[30];
//	int age;
//	//char gender;
//	char hobby[100];
//};
#include <string.h>
//


//



