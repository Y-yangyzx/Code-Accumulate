#pragma once
#include <stdio.h>

#define ROW 3
#define COL 3

//声明数组
void Initboard(char board[ROW][COL],int row,int col);
void Displayboard(char board[ROW][COL], int row, int col);
void Palyermove(char board[ROW][COL], int row,int col);
void Computermove(char board[ROW][COL], int row, int col);


//判断输赢四种情况：
//玩家胜     '*'
//电脑胜     '#'
//平局       'Q'
//继续游戏   'C'
char Iswin(char board[ROW][COL],int row,int col);
//判断棋盘是否平局函数
int IsFull(char board[ROW][COL], int row, int col);

