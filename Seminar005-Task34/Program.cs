/*
    Задача 34. Задайте массив заполненный случайными положительными трехзначнымичислами.
    Напишите программу, которая покажет количество четных чисел в массиве.

    [345,897,568,234] -> 2

    1. Метод CreateAndFillArray() создает,заполняет, возвращает массив целых  чисел.
        - size, параметр который определеяет размер массива, по умлочанию 4
        - min и max параметры которые задают левую и правую границу генерируемого случайного числа
        по умлочанию min = 100, max = 1000

    2. Метод GetCountOfEvenNumbers() ведет подсчет и возвращает количество четных  целых чисел в массиве котрый передается на вход в метода

    3. Метод CheckingSolution() метод проверки работы метода GetCountOfEvenNumbers().

 */

int[] CreateAndFillArray(int size = 4, int min = 100, int max = 1000)
{

    int[] returnArray = new int[size];
    for (int i = 0; i < returnArray.Length; i++)
    {
        returnArray[i] = new Random().Next(min, max);
    }
    return returnArray;
}

int GetCountOfEvenNumbers(int[] input)
{

    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] % 2 == 0) count++;
    }

    return count;
}

int[] testCase = { 345, 897, 568, 234 };
int testAnswer = 2;

Console.WriteLine($"[{string.Join(",", testCase)}] -> {GetCountOfEvenNumbers(testCase)}");

bool CheckingSolution(int[] checkingArray, int answer)
{

    return (GetCountOfEvenNumbers(checkingArray) == answer) ? true : false;
}

Console.WriteLine(CheckingSolution(testCase, testAnswer));