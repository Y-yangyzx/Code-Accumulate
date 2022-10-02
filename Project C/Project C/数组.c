#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <windows.h>
#include <stdlib.h>

//数组
//int main()
//{
//	//char arr[5] = {1,2,3,4,5};
//	char arr[] = "12345";
//	int sz = strlen(arr);
//	printf("%d\n",sz);
//	return 0;
//}



//***冒泡排序  对一组数组实现降序排序   把数组当做参数传进函数中
//void bubble_sort(int arr[], int sz)
//{
//	int i = 0;
//	//先确定循环的趟数
//	for (i = 0; i < sz-1; i++)
//	{
//		//再
//		int j = 0;
//		int flag = 1;
//		for ( j = 0; j < sz-1-i; j++)
//		{
//			if (arr[j]>arr[j+1])
//			{
//				int temp = 0;
//				temp = arr[j];
//				arr[j] = arr[j + 1];
//				arr[j + 1] = temp;
//				flag = 0;
//			}
//			if (flag == 1)
//			{
//				break;
//			}
//		}
//	}
//}





//
////main 拼错了！！！  导致程序没有显示    逻辑错误/拼音错误
//int main()
//{
//	int i = 0;
//	int arr[] = { 2,1,3,4,5,6,7,8,9 };
//	int sz = sizeof(arr) / sizeof(arr[0]);
//	bubble_sort(arr,sz);
//	for ( i = 0; i < sz; i++)
//	{
//		printf("%d ",arr[i]);
//	}
//	return 0;
//}
