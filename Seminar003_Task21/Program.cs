/*
    Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3Д пространстве.
    A(3,6,8);B(2,1-7) -> 15.84
    A(7,-5,0);B(1,-1,9) -> 11.53
*/

int[] aPointCoordinates =  { 3, 6, 8 };
int[] bPointCoordinates =  { 2, 1, -7 };

double calcDistanceBetween2Points3D(int[] a, int[] b)
{
    Console.Write("A(" + string.Join(',', a)+");");
    Console.Write("B(" + string.Join(',', b)+")");
    Console.Write("->");

    double d = Math.Sqrt(Math.Pow((b[0] - a[0]), 2) +
                         Math.Pow((b[1] - a[1]), 2) +
                         Math.Pow((b[2] -a[2]), 2));

    return Math.Round(d, 2);

}

Console.WriteLine(calcDistanceBetween2Points3D(aPointCoordinates, bPointCoordinates));
Console.WriteLine(calcDistanceBetween2Points3D(new int[] {7,-5,0}, new int[] {1,-1,9}));