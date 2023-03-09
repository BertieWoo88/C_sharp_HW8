/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка*/


using System;
using static System.Console;
Clear();

int rows = asknum("количество строк массива");
int column = asknum("количество столбцов массива");
int[,] mass = GetArray(rows, column, 0, 9);
PrintArray(mass);
WriteLine();
SearchMinSumStr(mass);
int [,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int asknum(string name)
{
    Write($"Введите {name}: ");
    int n = int.Parse(ReadLine()!);
    return n;
}

void SearchMinSumStr (int[,] array)
{
    int[] sumstring = new int [array.GetLength(0)];
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {      
              sumstring[i] += array[i,j];
        }
    }
    int imin = 0;
    for (int i = 1; i<sumstring.Length;i++)
    {
        if (sumstring[i]<sumstring[imin]) imin = i;
    }
    //Console.WriteLine($" [{String.Join(", ", sumstring)}] ");
    WriteLine($"{imin+1} строка с минимальной суммой элементов {sumstring[imin]}");
}

