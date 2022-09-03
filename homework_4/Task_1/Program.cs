//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Enter number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PowerNumbers(num1,num2));

double PowerNumbers (int number1, int number2)
{
    double result = Math.Pow(number1, number2);
    return result;
}




