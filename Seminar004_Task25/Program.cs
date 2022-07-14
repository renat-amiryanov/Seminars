/*
    Задача 25. Написать цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В

    3, 5 -> 243
    2, 4 -> 16
*/


int a = 3, b = 5;
int getPower(int numberA, int powerB)
{
    int powerNum = 1;
    for (int i = 0; i < powerB; i++)
    {
        powerNum *= numberA;
    }
    return powerNum;
}

Console.WriteLine($"{a}, {b} -> {getPower(a,b)}"); //  3, 5 -> 243
a = 2; b = 4;
Console.WriteLine($"{a}, {b} -> {getPower(a,b)}"); // 2, 4 -> 16
