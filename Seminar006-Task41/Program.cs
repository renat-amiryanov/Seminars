/*
    Задача 41. Пользователь вводит с клавиатуры M чисел.
    Посчитать, сколько чисел больше 0 ввел пользователь.
*/

int[] CreateAndFillArray(int m)
{
    int[] numbers = new int[m];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = int.Parse(Console.ReadLine());
    }

    return numbers;
}
int GetCountOfPositiveNumbers(int[] numbers, int i = 0)
{
    int count = 0;
    if (numbers[i] > 0) count++;
    if (numbers.Length - 1 != i)
    {
        return count + GetCountOfPositiveNumbers(numbers, i + 1);
    }
    else
    {
        return count;
    }
}

int[] inputArray = CreateAndFillArray(5);
Console.WriteLine($"[{string.Join(",", inputArray)}] -> {GetCountOfPositiveNumbers(inputArray)}");

