/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

using System;
using static System.Console;
Clear();

int el1 = asknum("размерность 1");
int el2 = asknum("размерность 2");
int el3 = asknum("размерность 3");
int[,,] massA = GetArray(el1, el2, el3);
PrintArray(massA);

int[,,] GetArray(int m, int n, int l)
{
    int[,,] result = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
                result[i, j, k] = asknum($"[{i},{j},{k}] элемент");
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)  // Выдает массив в том порядке что показано в примере
{
    for (int i = 0; i < inArray.GetLength(2); i++) // перебирает столбцы
    {
        for (int j = 0; j < inArray.GetLength(0); j++) // перебирает массивы
        {
            for (int k = 0; k < inArray.GetLength(1); k++) // перебирает строки
            {
                Write($"{inArray[j, k, i]} ({j},{k},{i}) "); 
                
            }
        WriteLine();
        }
        //WriteLine();
    }
}

int asknum(string name)
{
    Write($"Введите {name}: ");
    int n = int.Parse(ReadLine()!);
    return n;
}