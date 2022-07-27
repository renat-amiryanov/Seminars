/*
    Задача 64. Задайте значения M и N. Напишите программу которая выведет все натуральные числа от M до N
    M = 1; N =5.->"1,2,3,4,5"
*/

string RealNumbers(int M, int N)
{
    return M == N ? N.ToString() : M.ToString() + ", " + RealNumbers(M += 1, N);
}

int M = 1;
int N = 5;
string result = RealNumbers(M, N);
System.Console.WriteLine($"M = {M}; N = {N}. ->\"\"{result}\"\"");


M = 4;
N = 8;
result = RealNumbers(M, N);
System.Console.WriteLine($"M = {M}; N = {N}. ->\"\"{result}\"\"");