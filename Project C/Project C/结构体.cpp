#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>


//struct stuu   //stuu 叫结构体标签
//{
//	char name[20];
//	char sex[5];
//	int age;
//	char tele[12];
//};
//
//typedef struct stu  //结构体标签名也不能重复
//{
//	double d;
//	int a;
//	//int arr[20];
//	struct stuu s;
//}Stu;      //自定义名字
//int main()
//{
//	//结构体
//	//struct stuu s1 = {"张小明","男",12,"15532577805"}; //局部变量
//
//	Stu s2 = { 3.14,34,{"张小明","男",12,"15532577805"} };
//	/*printf("%s\n",s1.name);
//	printf("%s\n", s1.sex);
//	printf("%d\n", s1.age);
//	printf("%s\n",s1.tele);*/
//	//关于输出语句所应适用的%字母 要搞清楚否则会出错
//	printf("%d\n", s2.s.age);
//	printf("%lf\n", s2.d);
//	printf("%s\n", s2.s.sex);
//	return 0;
//}




//typedef struct Stu
//{
//	char name[20];
//	int age;
//	char sex[5];
//	char hobby[100];
//}Stu;
//struct Book
//{
//	char name[30];
//	int a;
//	double b;
//	char c[50];
//	struct Stu s;
//};
//int main()
//{
//	Stu s1 = {"张飞",30,"男","吃喝拉撒睡~"};
//	struct Book s2 = { "苏东坡传",55,3.14,"很好看",{"张飞",30,"男","吃喝拉撒睡~"} };
//	printf("%d\n", s1.age);
//	printf("%s\n", s1.hobby);
//	printf("%lf\n", s2.b);
//	printf("%s\n", s2.s.name);
//	return 0;
//}



//利用函数实现结构体变量内容的输出



struct pr
{
	char name[20];
	int age;
	double d;
	char str[60];
};

//需要把它写在结构体下方 因为要访问到结构体里的内容
//传值方法
void Printf(struct pr p)
{
	printf("%s\n", p.name);
	printf("%d\n", p.age);
	printf("%lf\n", p.d);
	printf("%s\n", p.str);
};
//传址方法    注意输出格式
void Printff(struct pr* p)
{
	printf("%s\n", p->name);
	printf("%d\n", p->age);
	printf("%lf\n", p->d);
	printf("%s\n", p->str);
}

int main()
{
	struct pr p = {"曹操",67,3.14,"哈哈哈哈哈"};
	Printf(p);
	//这种方式更好
	Printff(&p);
	return 0;
}