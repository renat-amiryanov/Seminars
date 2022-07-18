/*
    Задача 38. Задайте массив вещественных чисел
    Найдите разницу между максимальным и минимальными элементов массива.

    [3 7 22 2 78] -> 76

*/

double[] realNumbers = { 3, 7, 22, 2, 78 };

double[] FindMinAndMax(double[] inputArray)
{

    double[] minMaxArray = new double[2];
    minMaxArray[0] = inputArray[0];
    minMaxArray[1] = inputArray[inputArray.Length - 1];

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (minMaxArray[0] > inputArray[i]) minMaxArray[0] = inputArray[i];
        if (minMaxArray[1] < inputArray[i]) minMaxArray[1] = inputArray[i];
    }
    return minMaxArray;
}

double Sub(double[] inputArray) { return inputArray[1] - inputArray[0]; }

Console.WriteLine($"[{string.Join(" ", realNumbers)}] -> {Sub(FindMinAndMax(realNumbers))}");


