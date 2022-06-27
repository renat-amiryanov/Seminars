/*
Задача 4. Написать программу, которая на вход принимает три числа
и выдает максимальное из этих чисел.
*/

Console.WriteLine("Программа, которая на вход принимает три числа\n" +
"и выдает максимальное из этих чисел.");

Console.Write("Введите первое число:\t");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:\t");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:\t");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine("{0} {1} {2} -> {3}", a, b, c, max);

