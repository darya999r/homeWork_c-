//Задача 43: Напишите программу, которая найдёт 
//точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//k1*x - y + b1 = 0
//k2*x - y + b2 = 0


Console.Write("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

//по формуле Крамера:
double x = -(b1*(-1)-b2*(-1))/(k1*(-1)-k2*(-1));
double y = -(k1*b2-k2*b1)/(k1*(-1)-k2*(-1));

Console.WriteLine("Point of intersection: " + "(" + x + "; " + y + ")");

