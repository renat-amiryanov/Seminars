/*
    Задача 6. Написать программу, которая на вход принмает число
    и выдает, является ли число четным (делится ли оно два без остатка)
*/

Console.WriteLine("Программа, которая на вход принимает число и " 
+ "выдает является ли число четным(делится ли оно на  два без остатка).");

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

string evenOrOdd = number % 2 == 0 ? number + " -> да" : number + " -> нет";

Console.WriteLine(evenOrOdd);