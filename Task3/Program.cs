/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


using System;
using static System.Console;
Clear();

int rows = asknum("количество строк массива A");
int column = asknum("количество столбцов массива A");
int[,] massA = GetArray(rows, column, 0, 9);
PrintArray(massA);
rows = asknum("количество строк массива B");
column = asknum("количество столбцов массива B");
int[,] massB = GetArray(rows, column, 0, 9);
PrintArray(massB);
WriteLine();
PrintArray(MultiMatrix(massA, massB));

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

int[,] MultiMatrix (int[,] A, int [,] B)
{  
    if (A.GetLength(1) != B.GetLength(0) ) 
    {
        WriteLine("Перемножение данных матриц не возможно так как число столбцов в первой не равно числу строк во втрой ");
        return new int[0,0];
    } 
    int [,] product = new int [A.GetLength(0), B.GetLength(1)];
     for (int i = 0; i <product.GetLength(0); i++)
    {
        for (int j = 0; j <product.GetLength(1); j++)
        {
           for (int k = 0; k < A.GetLength(1); k++)
           {
             product[i,j] += A[i,k] * B[k,j]; 
           } 
        }
    }
    return product;
}   