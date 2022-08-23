//Задача 4
//Напишите программу, которая принимает на вход три числа
//и выдает максимальное из этих чисел.

Console.Write("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if(number1>number2 && number1>number3)
{
    Console.WriteLine(number1 + " - maximal number.");
}
if(number2>number1 && number2>number3)
{
    Console.WriteLine(number2 + " - maximal number.");
}
if(number3>number1 && number3>number2)
{
    Console.WriteLine(number3 + " - maximal number.");
}
