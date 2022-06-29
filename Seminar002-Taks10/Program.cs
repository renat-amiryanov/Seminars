/*
Задача 10. Написать программу которая на вход принимает трех значное число
и на выходе показывает вторую цифру этого числа

456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Введите трех значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int findAndPrintMiddleDigit(int number)
{
    Console.Write(number + " -> ");
    return (number / 10) % 10;
}

Console.WriteLine(findAndPrintMiddleDigit(number));
