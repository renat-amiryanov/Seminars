/*
    Задача 47. Задайте двуменый массив размеров m*n, заполненный случайными вещестренными числанми

    m = 3, n =4
*/

double[,] CreateAndFill2DimensionalArray(int rows, int cols, int min, int max)
{

    double[,] twoDimArray = new double[rows, cols];
    Random random = new Random();
    for (int i = 0; i < twoDimArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimArray.GetLength(1); j++)
        {
            twoDimArray[i, j] = random.Next(min, max) + random.NextDouble();
        }
    }

    return twoDimArray;
}

void DisplayArray(double[,] input)
{
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            Console.Write($"{input[i, j]:0.0}\t");
        }
        Console.WriteLine();
    }
}

int m = 3;
int n = 4;
int from = -10;
int to = 11;
DisplayArray(CreateAndFill2DimensionalArray(m, n, from, to));

//Console.WriteLine(string.Join(",", CreateAndFill2DimensionalArray(3,4,0,10)));