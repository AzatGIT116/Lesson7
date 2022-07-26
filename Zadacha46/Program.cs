﻿/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами. */

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if(j==0) Console.Write(" | ");
            Console.Write($"{mtrx[i, j], 3} | ");
        }
        Console.WriteLine();
    }
}

int[,] result = GetMatrix(3, 4, 1, 20);
PrintMatrix(result);
