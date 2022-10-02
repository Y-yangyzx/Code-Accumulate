#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <windows.h>
#include <stdlib.h>
#include "game(三子棋).h"

//void menu()
//{
//	printf("***********************\n");
//	printf("*****1.game 0.exit*****\n");
//	printf("***********************\n");
//}
//void game()
//{
//	int ret = 0;
//	char board[ROW][COL] = { 0 };
//	//初始化三子棋
//	Initboard(board,ROW,COL);
//	//打印三子棋的框架
//	Displayboard(board,ROW,COL);
//	
//	//下棋
//	while (1)
//	{
//
//		//玩家下棋
//		Palyermove(board,ROW,COL);
//		Displayboard(board, ROW, COL);
//		//判断谁赢谁输了
//		//玩家下完棋的判断
//		ret = Iswin(board, ROW, COL);
//		if (ret != 'C')
//		{
//			break;
//		}
//
//		//电脑下棋
//		Computermove(board,ROW,COL);
//		Displayboard(board, ROW, COL);
//		//电脑下完棋的判断
//		ret = Iswin(board,ROW,COL);
//		if (ret != 'C')
//		{
//			break;
//		}
//	}
//	if (ret == '*')
//	{
//		printf("玩家赢\n");
//	}
//	else if (ret == '#')
//	{
//		printf("电脑赢\n");
//	}
//    else
//	{
//		printf("平局\n");
//	}
//
//
//}
//void test()
//{
//	int input = 1;
//	srand((unsigned int) time(NULL));
//	while (input)
//	{
//		menu();
//		printf("请选择：");
//		scanf("%d", &input);
//		switch (input)
//		{
//		case 1:
//			game();
//			break;
//		case 0:
//			printf("退出游戏！");
//			break;
//		default:
//			printf("输入错误，请重新输入：\n");
//			break;
//		}
//	}
//	
//}

//程序入口
//int main()
//{
//	test();
//	return 0;
//}