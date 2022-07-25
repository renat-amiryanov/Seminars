/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2  a[0,0]+a[0,1]+a[0,2]+a[0,3] = 1+4+7+2 = 14 
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/
int[] GetSumOfArrayRow(int[,] values)
{

    int row = values.GetLength(0);
    int col = values.GetLength(1);
    int[] returnArray = new int[values.GetLength(0)];
    for (int i = 0; i < row; i++)
    {

        for (int j = 0; j < col; j++)
        {
            returnArray[i] += values[i, j];

        }

    }
    return returnArray;
}


int[,] array2D = {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
    {5,2,6,7}
};

int[] sumArrayRowsElements = GetSumOfArrayRow(array2D);
System.Console.WriteLine(String.Join(",", sumArrayRowsElements));