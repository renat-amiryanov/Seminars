/*
Задача 60. 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)

*/

int[] UniqueArray(int size)
{

            int[] a = new int[size];          
            for (int i = 0; i < a.Length; i++)
            {               
                var randomNumber= new Random().Next(10, 100);
                while(a.Any(v => v == randomNumber))
                {
                    randomNumber = new Random().Next(10, 100);
                }
                a[i] = randomNumber;
                
            }
            return a;
       
}

int[,,] Generate3DArray(int n)
{
    int[,,] array3D = new int[n, n, n];
    int[] uniqueNumbers = UniqueArray(array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2));

    int counter = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++, counter++)
            {
                array3D[i, j, k] = uniqueNumbers[counter];
            }
        }
    }
    return array3D;

}
void Display3DArray(int[,,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            for (int k = 0; k < data.GetLength(2); k++)
            {
                System.Console.Write($"{data[i, j, k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

int[,,] result = Generate3DArray(2);

Display3DArray(result);
