/*
    Задача 15. Напишите программу, котарая принимает на вход цифру,
    обозначающую день недели, и проверяет, является ли этот день выходным
*/
Console.Write("Введите цифру обоначающую день недели: ");
int dayNumberOfWeek = Convert.ToInt32(Console.ReadLine());
string checkIsHolyday(int dayNumber)
{
    Console.Write(dayNumber + " -> ");

    switch (dayNumber)
    {
        case 1:
            return "Нет";
           
        case 2:
            return "Нет";
           
        case 3:
            return "Нет";
           
        case 4:
            return "Нет";
            
        case 5:
            return "Нет";
            
        case 6:
            return "Да";
            
        case 7:
            return "Да";
            
        default:
            return "Некорректный ввод. Такого номера дня не существет.";
           
    }
}

Console.WriteLine(checkIsHolyday(dayNumberOfWeek));
