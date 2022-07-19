/*
    Задача 43.
    Напишите программу, которая найдет точку пересечения 2-х прямых, 
    заданных уравнениями y = k1*x + b1, y = k2*x + b2;
    значения b1, k1, b2 и k2 задаются пользователем

    b1 = 2, k1 = 5, b2 = 4 и k2 = 9 -> (-0.5,0.5) 

    y = k1*x + b1       y - y = k1*x + b1 -(k2*x + b2)      (b2-b1)/(k1-k2) = x
                    =>                                  =>
    y = k2*x + b2       y = k2*x + b2                      y = k2*x + b2

*/


}
void FindPointOfIntersection2Lines(double b1, double k1, double b2, double k2)
{
    if(k1 ==k2){
        Console.WriteLine("Прямые");
        }
    double x = (b2 - b1)/ (k1 - k2);
    double y = k2*x + b2;

    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2} и k2 = {k2} -> ({x:0.0},{y:0.0})");
}

FindPointOfIntersection2Lines(2,5,4,9);

FindPointOfIntersection2Lines(2,2,2,2);

