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
            break;
        case 2:
            return "Нет";
            break;
        case 3:
            return "Нет";
            break;
        case 4:
            return "Нет";
            break;
        case 5:
            return "Нет";
            break;
        case 6:
            return "Да";
            break;
        case 7:
            return "Да";
            break;
        default:
            return "Некорректный ввод. Такого номера дня не существет.";
            break;
    }
}

Console.WriteLine(checkIsHolyday(dayNumberOfWeek));
