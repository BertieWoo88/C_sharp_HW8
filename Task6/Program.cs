/***Задача 61: Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.

 */
using System;
using static System.Console;
Clear();

int row = asknum("число строк");
int[,] triangle = new int[row, row];
const int cellWidth = 3;
Filltriangle();
//PrintArray(triangle);
PrintTriangle();
void Filltriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriangle()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            SetCursorPosition(col, i + 1);
            if (triangle[i,j]!=0) Write($"{triangle[i,j],cellWidth}");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        WriteLine();
    }
        WriteLine();

}

int asknum(string name)
{
    Write($"Введите {name}: ");
    int n = int.Parse(ReadLine()!);
    return n;
}

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }