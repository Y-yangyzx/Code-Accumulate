#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>


//方法
//void Init(int arr[], int sz)
//{
//	for (int i = 0; i < sz; i++)
//	{
//		arr[i] = 0;
//	}
//}
//数组输出函数
//void Printf(int arr[], int sz)
//{
//	for (int i = 0; i < sz; i++)
//	{
//		printf("%d ", arr[i]);
//	}
//	printf("\n");
//}
//反转函数
//void reverse(int arr[], int sz)
//{
//	int left = 0;
//	int right = sz - 1;
//	int temp = 0;
//	while (left < right)
//	{
//		temp = arr[left];
//		arr[left] = arr[right];
//		arr[right] = temp;
//		left++;
//		right--;
//	}
//}


//int main()
//{
//	//实现反转函数reverse()
//	int arr[] = {1,2,3,4,5,6,7,8,9,10};
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	//初始化函数
//	//Init(arr,sz);
//	//输出函数
//	Printf(arr,sz);	
//	//反转函数
//	reverse(arr,sz);
//	//反转后再输出
//	Printf(arr,sz);
//	return 0;
//}

//int main()
//{
//	//实现两个数组内容的交换   注意：数组名是首元素地址
//	int arr1[] = {1,2,3,4,5};
//	int arr2[] = { 6,7,8,9,0 };
//	int temp=0;
//	int sz = sizeof(arr1) / sizeof(arr1[0]);
//	for (int i = 0; i < sz; i++)
//	{
//		temp = arr1[i];
//		arr1[i] = arr2[i];
//		arr2[i] = temp;
//	}
//	//数组输出要遍历输出
//	for (int j = 0; j < sz; j++)
//	{
//		printf("%d ", arr1[j]);		
//		//printf("%d ", arr2[j]);
//	}
//	printf("\n");
//	for (int k = 0; k < sz; k++)
//	{
//		printf("%d ", arr2[k]);
//	}
//}




//***计算二进制中1的位数
//方法一：
//存在缺陷：负数无法准确计算  改进 加上一个unsigned  将第一位不看成符号位
//第二种方法:让这个二进制数向右移位&一个1
//int count_bit_one(unsigned int n)
//{
//	int count = 0;
//	while (n)
//	{
      //求出余数
//		if (n%2==1)
//		{
//			count++;
//		}
      //去掉了上面所求的余数
//		n = n / 2;
//	}
//	return count;
//}


//方法二：
//-1在内存中存放的是补码
//11111111111111111111111111111111   一位一位向右移动
//00000000000000000000000000000001
//int count_bit_one(int n)
//{
//	int count = 0;
//	for (int i = 0; i < 32; i++)
//	{
//		if (((n>>i)&1)==1)
//		{
//			count++;
//		}
//	}
//	return count;
//}


//方法三：
//n=n&(n-1)
int count_bit_one(int n)
{
	int count = 0;
	while (n)
	{
		n = n & (n - 1);
		//只要n不为零  count ++
		count++;
	}
	return count;
}

//int main()
//{
//	//统计二进制数中1的个数   例：15  0000 1111
//	//思路：类比于十进制求1的个数  n%10 得到余数是否为1   再/10（去掉1这一位）  
//	int n = 0;
//	printf("请输入数字：");
//	scanf("%d",&n);
//	int count = count_bit_one(n);
//	printf("这个数中二进制的个数为：%d\n",count);
//}





//求二级制中不同位的个数  m、n中不相同的二进制位数
//方法一：一位一位比较（比较低效）
//方法二：异或

//int Get_count(int m, int n)
//{
//	int tmp = m ^ n;
//	int count = 0; 
//	//tmp存储的是m n两个变量中所有位数的^结果 相同为0 不同为1
//	//我们要找的是m、n中不同的二进制数  所以本题转化为求tmp中二进制位1的个数
//	//这就与上一道题联系起来了
//	while (tmp)
//	{
//		tmp = tmp & (tmp - 1);//tmp与tmp-1与多少次就出来多少个1  
//		count++;
//	}
// 	return count;
//}
//
////例子：10和5二进制不同的二进制个数
////1010 ---10
////0101 ---5
////不同的个数为4个
//int main()
//{
//	int m = 0;
//	int n = 0;
//	printf("请输入要比较的两个数字：");
//	scanf("%d %d", &m, &n);
//	int count = Get_count(m, n);
//	printf("%d\n", count);
//	return 0;
//}




//获取一个整数二进制序列中所有奇数位和偶数位  分别打印出来   
//涉及到的知识点：移位操作符  移动二进制位分别按位与上1
//void Get_bit(int n)
//{
//	//实现思路：奇偶分算 先循环算出奇数 从30开始每次-2(因为要从头向后输出)
//	//注意循环条件  >=0  
//	int i = 0;
//	for (i = 30; i >=0 ; i-=2)
//	{
//		printf("%d ",(n >> i) & 1);
//	}
//	printf("\n");
//	for (i = 31; i >= 1; i-=2)
//	{
//		printf("%d ", (n >> i) & 1);
//	}
//}
//int main()
//{
//	int n = 0;
//	printf("请输入一个整数：");
//	scanf("%d", &n);
//	Get_bit(n);
//	return 0;
//}



//例子：交换两个变量（不使用临时变量）
//int main()
//{
//	//方法一：加减法(好神奇)
//	//int a = 10;
//	//int b = 5;
//	//a = a - b;
//	//b = a + b;
//	//a = b - a;
//	//printf("%d %d",a,b);
//	//方法二：异或法(更神奇  但是我不理解)  
//	//这种方法是最常用的办法，也是最推荐的办法，这样不会产生超出范围等错误
//	//异或符号 ^ : 相同为0 ，相异为1
//	//前两个赋值语句：“a = a ^ b；”和“b = b ^ a；”相当于b = b ^ (a ^ b)，而b ^ a ^ b等于a ^ b ^ b。b ^ b的结果为0，因为同一个数与相向相^，结果必为0。因此b的值等于a ^ 0，即a，其值为10。
//	int a = 10;
//	int b = 5;
//	a = a ^ b;
//	b = a ^ b;
//	a = a ^ b;
//	printf("%d %d", a, b);
//	return 0;
//}



//void Printff(int arr[], int sz) 
//{
//	for (int i = 0; i < sz; i++)
//	{
//		printf("%d ", *(arr + i));
//	}
//}
//int main()
//{
//	//使用指针打印数组内容
//	int arr[] = { 1,2,3,4,5,6,7 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	/*Printff(arr,sz);*/
//	for (int i = 0; i < sz; i++)
//	{
//		//arr放在这同样是首元素地址
//		printf("%d ", *(arr + i));
//	}
//	return 0;
//}


//例子：输入一个数字打印相应n*n乘法表
//int main()
//{
//	int n = 0;
//	printf("请输入：");
//	scanf("%d", &n);
//	for (int i = 1; i <= n; i++)
//	{
//		for (int j = 1; j <= i; j++)
//		{
//			printf("%d*%d=%-3d ",j,i,i*j);
//		}
//		printf("\n");
//	}
//}


