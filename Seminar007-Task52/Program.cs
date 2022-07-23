/*
    Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов к каждом столбце.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4

    Среднее арифметическое каждого столбца:4,6;5,6;3,6;3.


    1 4 7 2     a[0,0]+a[1,0]+a[2,0] = 1+5+8 = 14  
    5 9 2 3     a[0,1]+a[1,1]+a[2,1] = 4+9+4 = 17
    8 4 2 4     a[0,2]+a[1,2]+a[2,2] = 7+2+2 = 11
                a[0,3]+a[1,3]+a[2,3] = 2+3+4 = 9
*/



void Display2D(int[,] values)
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
void GetSumCalcAvgOfColumnsValueAndDisplay(int[,] arr2D)
{
        
    int row = arr2D.GetLength(0);
    int col = arr2D.GetLength(1);
    double[] result = new double[col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[j] += arr2D[i, j];
        }
    }
    for (int i = 0; i <  result.Length; i++) 
    {
        Console.Write($"{(result[i]/row):0.00}; ");
    }  
    Console.WriteLine(); 
}

int[,] array2D = {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};
Display2D(array2D);
System.Console.Write("Среднее арифметическое каждого столбца: ");
GetSumCalcAvgOfColumnsValueAndDisplay(array2D);