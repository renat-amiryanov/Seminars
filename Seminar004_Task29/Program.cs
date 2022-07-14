/*
    Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран

    1,2,5,7,19 -> [1,2,5,7,19]
*/

string testString = "1,0,5,7";

 int[] ReturnIntNumbersArray(string data){

    string[] tempStringArray = data.Split(',');

    int [] returningArray = new int[8];

    int i,j;   
   
    for (i = 0, j = 0; i < returningArray.Length && j < tempStringArray.Length; i++, j++)
    {   
        returningArray[i] = int.Parse(tempStringArray[i]);      
    }

    return returningArray;
}

string resultString = string.Join(",", ReturnIntNumbersArray(testString));
Console.Write($"{testString} -> [{resultString}]");



