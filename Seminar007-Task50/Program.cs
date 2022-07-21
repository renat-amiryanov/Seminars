/*
    Задача 50. Напишите программу, которая на вход принимает позиции элемена в двумерном массиве
    и возвращает значение этого элемента или же указание, что такого элемента нет
*/


string GetValueByPosition(int[,] data, int rowIdx, int colIdx)
{
    string retValue = "Не найдено";

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

int row = 2, col = 1;
string result = GetValueByPosition(numbers, row, col);
Console.WriteLine(result);