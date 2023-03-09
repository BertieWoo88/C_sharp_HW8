/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


using System;
using static System.Console;
Clear();

int rows = asknum("количество строк и столбцов массива");
int[,] massA = GetSperalArray(rows);
PrintArray(massA);

int [,] GetSperalArray (int m)
{   int row = 0;
    int column = 0;
    int[,] result = new int[m, m];
    int[,] variants = new int[,] //массив с вариантами выбора направления следующей координаты
    {  { 0, 1, 0, -1 },
       { 1, 0, -1, 0 } 
    };
    int cicle = 0; //выбор варианта из массива variants
   for(int i = 1; i<=m*m; i++)
    {
        // WriteLine($"row {row} column {column} i {i} cicle {cicle}");
        result[row,column] = i;
        if (row+variants[0,cicle]>result.GetLength(0)-1 
        || column+variants[1,cicle]>result.GetLength(1)-1
        || row+variants[0,cicle]<0
        || column+variants[1,cicle]<0)
        {   
        cicle++;
        } 
        else 
        {    
        if (result[row+variants[0,cicle], column+variants[1,cicle]]!=0) cicle++;
        }
        if (cicle>3) cicle = 0;
        row +=variants[0,cicle];
        column +=variants[1,cicle];
    }
    
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j].ToString("00")} ");
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
