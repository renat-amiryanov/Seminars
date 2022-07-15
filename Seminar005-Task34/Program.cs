/*
    Задача 34. Задайте массив заполненный случайными положительными трехзначнымичислами.
    Напишите программу, которая покажет количество четныхчисле в массиве.

    [345,897,568,234] -> 2

    n % 2 == 0 

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
        if (input[i] % 2 == 0) count++  ;
    }

    return count;
}

int[] testCase = {345,897,568,234};
int testAnswer = 2;

bool CheckingSolution(int[] checkingArray, int answer)
{   
    Console.WriteLine(string.Join(",", checkingArray));
    return (GetCountOfEvenNumbers(checkingArray) == answer) ? true : false;
}


Console.WriteLine(CheckingSolution(testCase,testAnswer));