#define _CRT_SECURE_NO_WARNINGS 1

#include "game(三子棋).h"


void Initboard(char board[ROW][COL],int row,int col)
{
	//将所有内容初始化为空格   二维数组的遍历  然后让每一个输入内容都为空
	int i = 0;	
	int j = 0;
	for (i = 0; i < row; i++)
	{
		for (j = 0; j < col; j++)
		{
			//字符型  ！！！！！
			board[i][j] = ' ';
		}
	}
}

void Displayboard(char board[ROW][COL], int row, int col)
{
	int i = 0;
	int j = 0;
	for ( i = 0; i < row; i++)
	{
		//1.打印一行数据
		//printf(" %c | %c | %c \n",board[i][0],board[i][1],board[i][2]);  写死了就是三行的
		for (j = 0; j < col; j++)
		{
			printf(" %c ", board[i][j]);
			if (j < col - 1)
			{
				printf("|");
			}
		}
			printf("\n");
			//2. 打印分割行
			if (i < row - 1)  //不要打印最下方的--- --- ---了
			{
				//printf("---|---|---");
				for (j = 0; j < col; j++)
				{
					printf("---");
					if (j<col-1)
					{
						printf("|");
					}
				}
				printf("\n");
			}
	}
}


void Palyermove(char board[ROW][COL], int row, int col)
{
	printf("玩家下棋：>\n");
	while (1)
	{
		int x = 0;
		int y = 0;
		printf("请输入坐标:");
		scanf("%d%d", &x, &y);
		//判断坐标的合法性
		if (x >= 1 && x <= row && y >= 1 && y <= col)
		{
			if (board[x-1][y-1] == ' ')
			{
				board[x - 1][y - 1] = '*';
				break;
			}
			else
			{
				printf("该坐标已被占用，请重新输入！\n");
			}
		}
		else
		{
			printf("坐标不合法，请重新输入！\n");
		}
	}
}


//电脑下棋
void Computermove(char board[ROW][COL], int row, int col)
{
	int x = 0;
	int y = 0;
	printf("电脑下棋：>\n");
	while (1)
	{
		x = rand() % row;
		y = rand() % col;
		if (board[x][y]==' ')
		{
			board[x][y] = '#';
			break;
		}
	}

}


int IsFull(char board[ROW][COL], int row, int col)
{
	int i = 0;
	int j = 0;
	for ( i = 0; i < row; i++)
	{
		for (j = 0; j < col; j++)
		{
			if (board[i][j] == ' ')
				return 0;
		}
	}
	return 1;
}

//判断输赢函数
char Iswin(char board[ROW][COL], int row, int col)
{
	int x = 0;
	int y = 0;
	//横三行一条线
	for (int i = 0; i < row; i++)
	{
		if (board[i][0]==board[i][1]&&board[i][1]==board[i][2] &&board[i][1]!=' ')
		{
			return board[i][1];
		}
	}
	//从三列一条线
	for (int j = 0; j < col; j++)
	{
		if (board[0][j]==board[1][j]&&board[1][j]==board[2][j] &&board[1][j]!=' ')
		{
			return board[1][j];
		}
	}
	//斜两条
	if (board[0][0]==board[1][1]&&board[1][1]==board[2][2] && board[1][1]!=' ')
	{
		return board[1][1];
	}
	if (board[0][2]==board[1][1]&&board[1][1]==board[2][0] &&board[1][1]!=' ')
	{
		return board[1][1];
	}
	
    
	//判断是否平局  再写一个函数IsFull()
	if (IsFull(board,ROW,COL)==1)
	{
		return 'Q';
	}
	return 'C';
}