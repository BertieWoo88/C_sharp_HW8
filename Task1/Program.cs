/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

using System;
using static System.Console;
Clear();

int rows = asknum("количество строк массива");
int column = asknum("количество столбцов массива");
int[,] mass = GetArray(rows, column, 0, 9);
PrintArray(mass);
WriteLine();
SortStrings(mass);
PrintArray(mass);
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

void SortStrings (int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {  
            for (int k = 0; k<array.GetLength(1)-1-j; k++ )
            {    
                if (array[i,k]<array[i,array.GetLength(1)-1-j])
            {
                int temp = array[i,k];
                array[i,k] = array[i,array.GetLength(1)-1-j];
                array[i,array.GetLength(1)-1-j] = temp;
            }
            }
        }
    }
}