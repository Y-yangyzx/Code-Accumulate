#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
//分支和循环
//int main()
//{
//例子1：判断一个是是否为奇数
	//奇数%2 == 1
	//int num = 0;
	//scanf("%d", &num);
	//if (num % 2 == 1)
	//{
	//	printf("输入的数字是奇数\n");
	//}
	//else
	//{
	//	printf("输入的数字不是奇数\n");
	//}
//例子2：输出1-100之间的奇数（用时1min比较合适）
	//int num = 1;  //初始的变量
	//while (num>=1 && num <=100)   //循环条件
	//{
	//	if (num % 2 == 1)   //判断条件
	//	{
	//		printf("%d\n",num);   
	//	}
	//	num++;    //放在这而不能放在if循环中 
	//}


//例子3：多分支情况：输入1-7分别代表星期一到星期日
//	int day = 0;
//	while(1)
//	{ 
//	printf("请输入数字：");
//	scanf("%d",&day);   //不能在%d后加一个换行
//	switch (day)
//	{
//	case 1:
//		printf("星期一\n");
//		break;
//	case 2:
//		printf("星期二\n");
//		break;
//	case 3:
//		printf("星期三\n");
//		break;
//	case 4:
//		printf("星期四\n");
//		break;
//	case 5:
//		printf("星期五\n");
//		break;
//	case 6:
//		printf("星期六\n");
//		break;
//	case 7:
//		printf("星期日\n");	
//		break;
//	default:  //可有可无
//		printf("输入数字不在1-7之间！请重新输入！\n");
//		break;    //依然给一个break 
//	}
//	}
//	return 0;
//}


//int main()
//{
//	/*int a = 0;
//	while ((a = getchar()) != EOF)
//	{
//		putchar(a);
//	}*/
//	char ch;
//	int re; //不太理结为什么也能用int
//	char password[20] = { 0 };
//	printf("请输入密码：");
//	scanf("%s",password);    //\n不要加 加了就要多输入一次
//	printf("请确认：Y/N\n");
//	while ((re = getchar()) != '\n')  
//		//判断输入缓存区中是否还存在'\n'
//		//循环判断   循环体中没有语句
//	{
//		;
//	}
//	
//	ch = getchar();
//	if (ch == 'Y')
//	{
//		printf("确认成功！");
//	}
//	else
//	{
//		printf("确认失败！");
//	}
//	return 0;
//}




