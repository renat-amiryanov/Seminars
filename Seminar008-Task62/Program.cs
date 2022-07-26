/*

Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1   2   3   4
12  13  14  5
11  16  15  6
10  9   8   7
*/

int[,] SpiralFilledMatrix()
{
    int[,] matrix = new int[4, 4];

    int yStart = 0;
    int yEnd = matrix.GetLength(0) - 1;

    int xStart = 0;   
    int xEnd = matrix.GetLength(1) - 1;

    int moveDirection = 0; 
    int num = 1;

    while (xStart <= xEnd && yStart <= yEnd)
    {

        if (moveDirection == 0)
        {
            for (int i = xStart; i <= xEnd; i++)
            {
                matrix[yStart, i] = num;
                num++;

            }
            yStart++;
        }
        else if (moveDirection == 1)
        {
            for (int i = yStart; i <= yEnd; i++)
            {
                matrix[i, xEnd] = num;
                num++;

            }
            xEnd--;
        }
        else if (moveDirection == 2)
        {
            for (int i = xEnd; i >= xStart; i--)
            {
                matrix[yEnd, i] = num;
                num++;

            }
            yEnd--;
        }
        else if (moveDirection == 3)
        {
            for (int i = yEnd; i >= yStart; i--)
            {
                matrix[ i, xStart] = num;
                num++;

            }
            xStart++;
        }

        moveDirection = (moveDirection + 1) % 4;
    }

    return matrix;
}
void Display(int[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            System.Console.Write( $"{data[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

Display(SpiralFilledMatrix());

