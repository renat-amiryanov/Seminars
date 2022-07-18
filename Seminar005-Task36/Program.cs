/*
Задача 36 Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечетных позициях

[3, 7, 23, 12] -> 19
[-4,-6, 89, 6] -> 0
*/
int[] CreateAndFillArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100,101);
    }

    return numbers;
}

int GetSumOfNumbersOnOddPosition(int[] inputArray){

    int returnValue = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if(i % 2 != 0) returnValue +=inputArray[i];
    }
    
    return returnValue;
} 
int[] test1 ={3, 7, 23, 12};
int[] test2 ={-4,-6, 89, 6};

Console.WriteLine($"[{string.Join(",",test1)}] -> {GetSumOfNumbersOnOddPosition(test1)}");
Console.WriteLine($"[{string.Join(",",test2)}] -> {GetSumOfNumbersOnOddPosition(test2)}");

Console.WriteLine();
int[] randomFillArray = CreateAndFillArray(4);
Console.WriteLine($"[{string.Join(",",randomFillArray)}] -> {GetSumOfNumbersOnOddPosition(randomFillArray)}");