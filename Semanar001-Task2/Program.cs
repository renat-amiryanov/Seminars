/* Задача2. Напишите программу, которая на вход принимает два числа
и выдает, какое число большее, а какое меньшее.
a = 5, b = 7 -> max = 7*/

Console.WriteLine("Программа, которая на вход принимает два числа\n"
+ "и выдает, какое число большее, а какое меньшее.");
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int min = a, max = b;
if (a > max)
{
    int tmp = max;
    max = a;
    min = tmp;
}
Console.WriteLine("a = {0}, b = {1} -> min = {2}, max = {3}", a, b, min, max);
Console.WriteLine("Программа завершена.");
