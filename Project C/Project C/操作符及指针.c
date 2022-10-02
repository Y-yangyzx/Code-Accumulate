#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
//例：计算出一个数二进制中1的个数     移位操作符
//三种方法









//~  <<  >>  操作符的应用例子
//int main()
//{
//	//这种题相对来说稍微的乱一点点但是只要耐下心来去分析  万事皆可成
//
//    int a = 11;
//	//a的二进制序列
//	//00000000000000000000000000001011
//	//需求：将倒数第三位的0改为1   思路：保证别的未不变  给这个0|1
//	//00000000000000000000000000000100      变换一种形式:1向左移动2位
//	a = a | (1 << 2);
//	printf("%d\n",a);
//	//此时a的二进制序列为
//	//00000000000000000000000000001111
//	//11111111111111111111111111111011   直接要&的二进制序列
//	//00000000000000000000000000001011   相对来说没有什么规律！！！ 不能用移位符了
//	//00000000000000000000000000000100   转换的
//	//1&0  为0   只有1&1   才是1
//	//需求：把那个0改回来    
//	a = a & (~(1 << 2));
//	printf("%d\n",a);
//	return 0;
//}


//int* test()
//{
//	int a = 10;
//	return &a;
//}
//int main()
//{
	/*int a = 0;
	printf("%d\n",a++);
	printf("%d\n", a);*/

	/*printf("%d\n",sizeof(int*));
	printf("%d\n",sizeof(char*));
	printf("%d\n", sizeof(double*));*/

	//int a = 10;
	//int* pa = &a;
	//char* pc = &a;
	//printf("%d\n",*pa);
	//printf("%p\n", pa+1);
	//printf("%p\n",pc+1);


	/*int n = 0x11223344;
	char* pc = (char*)&n;
	int* pa = &n;
	*pc = 0;
	*pa = 0;*/


	
	//利用指针遍历数组  将数组中的所有元素赋值为1
	//int arr[10] = { 0 };
	//int* p = arr;//数组名---首元素地址  &arr---取出整个元素地址
	////char* p = arr;
	//int i = 0;
	//for (i = 0; i < 10; i++)
	//{
	//	*(p + i)=1;
	//}



	
	//int arr[10] = {0};
	//int* p = arr; //首元素地址
	//int i = 0;
	//for ( i = 0; i < 10; i++)
	//{
	//	/*arr[i] = 1;*/
	//	*(p + i)=1;	
	//	printf("%d\n",arr[i]);
	//}
	

	////野指针---指针未初始化
	//int* p;
	//*p = 20;


	////野指针---越界访问
	//int arr[10] = { 0 };
	//int* p = arr;  //p是指针变量
	////越界访问   野指针
	////遍历数组的地址   因为for的循环体里写的是p（指针变量）
	//for (int i = 0; i < 12; i++)
	//{
	//	p++;
	//}
	//printf("%p\n",p);



    //空间释放
	
	/*int * p = test();
	*p = 20;
	return 0;*/
//

//用变量的方式
//int my_strlen(char arr[],int sz)
//{
//	int count = 0;
//	for (int i = 0; i < sz; i++)
//	{
//		count++;
//	}
//	return count;
//}


//这个思维你要get到
//int my_strlen(char* str)
//{
//	char* start = str;
//	char* end = str;
//	while (*end!='\0')
//	{
//		end++;
//	}
//	return (end - start);
//}
//int main()
//{
	//char arr[] = "hellow bit";
	////int sz = sizeof(arr) / sizeof(arr[0]);
	////用sizeof计算字符类型数组长度  要减去1(2) 因为把'\0'算在里面了  前提是字符型数组
 //   int len = my_strlen(arr);
	//printf("%d\n", len);


	//***通过指针变量给数组赋值
	//int arr[10] = { 0 };
	//int* p = arr;
	//for (int i = 0; i < 10; i++)
	//{
	//	*(p + i) = i+1;//通过指针变量给数组赋值  遍历一个个赋值
	//	printf("%d\n", *(p + i));//通过指针变量输出数组  遍历一个个输出
	//}
	


	//p（首元素地址）是指针变量 p+i（变量---存的是常数）  
	//int arr[10] = {0};
	//int sz = sizeof(arr) / sizeof(arr[0]);
	//int* p = arr;//存的首元素地址
	//for (int i = 0; i < sz; i++)
	//{
	//	printf("%p %p\n",p+i,&arr[i]);
	//}



	//利用指着变量遍历数组输出数组元素---关键首元素地址  然后利用i的变化使地址发生变化
	//int arr[] = { 1,2,3,4,5,6,7,8,9,10 };
	//int* p = arr;
	//for (int i = 0; i < 10; i++)
	//{
	//	printf("%d\n",*(p+i));
	//}
	/*return 0;
}*/


