/*
    Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов к каждом столбце.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4

    Среднее арифметическое каждого столбца:4,6;5,6;3,6;3.
*/

int[,] array2D = {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};

void Display(int[,] values)
{
    int row = values.GetLength(0);
    int col = values.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            System.Console.Write($"{values[i, j]} ");
        }
        Console.WriteLine();
    }

}

Display(array2D);