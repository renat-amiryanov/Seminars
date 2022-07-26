/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2 
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/


int GetIndexOfMinElementValueOfArray(int[] values)
{
    int index = 0;
    for (int i = 0; i < values.Length - 1; i++)
    {
        if (values[i] < values[index]) index = i;
    }
    return index;
}

void Display(int[,] values)
{
    for (int i = 0; i < values.GetLength(0); i++)
    {
        for (int j = 0; j < values.GetLength(1); j++)
        {
            Console.Write($"{values[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindIndexOfMiniValue(int[,] values)
{

    int[] returnArray = new int[values.GetLength(0)];

    for (int i = 0; i < values.GetLength(0); i++)
    {

        for (int j = 0; j < values.GetLength(1); j++)
        {
            returnArray[i] += values[i, j];
        }

    }
    return GetIndexOfMinElementValueOfArray(returnArray);
}


int[,] array2D = {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
    {5,2,6,7}
};

Display(array2D);
int row = FindIndexOfMiniValue(array2D);
System.Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {row} строка.");