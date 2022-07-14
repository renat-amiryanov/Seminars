/*
    Задача 27. Написать программу, которая принимает на ход число и  выдает сумму цифр в числе.

    452 -> 11
    82 -> 10
    9012 -> 12
*/


int calcSumOfDigitsInNumber(int inputNumber)
{
    int sum = 0;   

    while (inputNumber > 0)
    {

        sum = sum + inputNumber % 10;
        inputNumber /= 10;
    }
    return sum;
}

int testNumber = 452;
Console.WriteLine($"{testNumber} -> {calcSumOfDigitsInNumber(testNumber)}");

testNumber = 82;
Console.WriteLine($"{testNumber} -> {calcSumOfDigitsInNumber(testNumber)}");

testNumber = 9012;
Console.WriteLine($"{testNumber} -> {calcSumOfDigitsInNumber(testNumber)}");
