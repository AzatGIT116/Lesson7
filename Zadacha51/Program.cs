/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. */

int[,] array = new int[3, 5];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}

/* int CheckArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array[i, j];
            }
        }
    }
    return sum;
} */

int CheckArray2(int[,] array)
{
    int sum = 0;
    int index = 0;
    if (array.GetLength(0) > array.GetLength(1))
    {
        index = 1;
    }
    for (int i = 0; i < array.GetLength(index); i++)
    {
        sum += array[i, i];
    }

    return sum;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],2} | ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);
Console.WriteLine();
//int sumall = CheckArray(array);
int sumall = CheckArray2(array);
Console.WriteLine(sumall);