/* 
    Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

void Display(int[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            Console.Write($"{data[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] MultiplyMatrixes(int[,] a, int[,] b)
{
    if(a.GetLength(0) == b.GetLength(1)) System.Console.WriteLine("Умножать можно");
    else { throw new Exception("Умножать нельзя"); }
    
    int [,] resultOfMultypling = new int [a.GetLength(0),b.GetLength(1)];
    
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {   
            for (int k = 0; k < b.GetLength(0); k++)
            {
                 resultOfMultypling[i,j] += a[i,k] * b[k,j];
            }              
        }
    }

    return resultOfMultypling;
}

int[,] matrix1 ={
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
    {5,2,6,7}

};

int[,] matrix2 ={
    {1,5,8,5},
    {4,9,4,2},
    {7,2,2,6},
    {2,3,4,7}
};

Display(matrix1);
Console.WriteLine();
Display(matrix2);
int [,] answer = MultiplyMatrixes(matrix1, matrix2);
Console.WriteLine();
Display(answer);
