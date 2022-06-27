/*
    Задача 8. Написать прорамму, которая на вход принимает число (N),
    а на выходе показывает все четные числа от 1 до N
*/

Console.WriteLine("Программа, которая на вход принимает число (N),\n"
   + "а на выходе показывает все четные числа от 1 до N");

Console.Write("Введите число N: ");

int n = Convert.ToInt32(Console.ReadLine());

int counter = 1;

string message = n + " -> ";

while (counter <= n)
{
    if (counter % 2 == 0)
    {
        message = counter != n ? message + counter + ", " : message + counter;
    }
    counter++;
}

Console.WriteLine(message);