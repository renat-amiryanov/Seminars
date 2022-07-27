/* 
    Задача 66.
     Задайте значения M и N. Напишите программу которая выведет сумму натуральных элементов в промежутке от M до N
    M = 1; N = 15.-> 120
    M = 4; N = 8.-> 120
*/

int GetSumOfRealNumbers(int m, int n)
{
    return m == n ?  n: m += GetSumOfRealNumbers(m+1, n);
}

int m = 1;
int n = 15;
int sumOfRealNumbers = GetSumOfRealNumbers(m,n);
Console.WriteLine($"M = {m};N = {n} -> {sumOfRealNumbers}");

m = 4;
n = 8;
sumOfRealNumbers = GetSumOfRealNumbers(m,n);
Console.WriteLine($"M = {m};N = {n} -> {sumOfRealNumbers}");