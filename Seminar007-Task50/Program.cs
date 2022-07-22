/*
    Задача 50. Напишите программу, которая на вход принимает позиции элемена в двумерном массиве
    и возвращает значение этого элемента или же указание, что такого элемента нет
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

string GetValueByPosition(int[,] data, int rowIdx, int colIdx)
{
    string retValue = "такого числа в массиве нет";

    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            if (i == rowIdx && j == colIdx) return data[i, j].ToString();
        }
    }
    return retValue;
}

int[,] numbers = {
    {1,2,3},
    {4,5,6},
    {7,8,9}
};

int row = 1, col = 1;
Display(numbers);
string result = GetValueByPosition(numbers, row, col);
Console.WriteLine($"{row}{col} -> {result}");