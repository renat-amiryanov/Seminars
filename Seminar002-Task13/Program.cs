/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

//метод который возвращает длину заданного числа
int getLength(int n)
{
    int count = 0;
    while (n != 0)
    {
        n = n / 10;
        count++;
    }
    return count;
}

// метод в поиска и вывода третьей цифры
void findAndPrint3rdDigit(int number)
{
    Console.Write("{0} -> ", number);

    //проверяем длину заданного числа, если меньш 3, то выводим сообщение
    if (getLength(number) < 3)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        int counter = getLength(number) - 3;
        // Console.WriteLine(counter);
        while (counter != 0)
        {
            number = number / 10;
            counter--;
        }

        int thirdDigit = (number % 100) % 10;
        Console.WriteLine(thirdDigit);
    }

}

findAndPrint3rdDigit(645);
findAndPrint3rdDigit(78);
findAndPrint3rdDigit(32679);

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
findAndPrint3rdDigit(number);