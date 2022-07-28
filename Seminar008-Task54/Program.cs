/*

Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

1 2 4 7
2 3 5 9
2 4 4 8

*/
void Display(int[,] values)
{
    int row = values.GetLength(0);
    int col = values.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{values[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] SortingRows(int[,] values)
{
    int row = values.GetLength(0);
    int col = values.GetLength(1);
    int[,] sortedRows = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = col - 1; j > 0; j--)
        {
            for (int k = 0; k < j; k++)
            {
                if (values[i, k] > values[i, k + 1])
                {
                    int temp = values[i, k];
                    values[i, k] = values[i, k + 1];
                    values[i, k + 1] = temp;
                }

            }

        }
    }
    return values;
}

int[,] input = {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};

Console.WriteLine("Input:");
Display(input);

Console.WriteLine();

int[,] result = SortingRows(input);

Console.WriteLine("Output:");
Display(result);
