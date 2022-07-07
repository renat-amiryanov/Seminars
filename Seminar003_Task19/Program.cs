/*
    Задача 19. Написать программу которая принимает на вход пятизначное число и проверяет,
    является ли число палиндромом. 
*/

int a = 14212;
int b = 12821;
int c = 23432;

bool checkNumberIsPalindrom(int num)
{
    if (num < 0 || (num != 0 && num % 10 == 0)) // num % 10  исключает такие числа, как 10, 20,...,100,..
    {
        return false;
    }
    int temp = 0;

    while (temp < num)
    {
        temp = temp * 10 + num % 10;

        num = num / 10;
    }

    return (num == temp || num == temp / 10);

}
string message = (checkNumberIsPalindrom(a)) ? "да" : "нет";
Console.WriteLine(a + " -> " + message);

message = (checkNumberIsPalindrom(b)) ? "да" : "нет";
Console.WriteLine(b + " -> " + message);

message = (checkNumberIsPalindrom(c)) ? "да" : "нет";
Console.WriteLine(c + " -> " + message);