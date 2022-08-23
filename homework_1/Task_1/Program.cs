//Задача 2
//Напишите программу, которая на вход принимает два числа и выдает, 
//какое число большее, какое меньшее.

Console.Write("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1>number2)
{
    Console.WriteLine(number1 + " - larger number.");
    Console.WriteLine(number2 + " - smaller number.");
}
else
{
    Console.WriteLine(number2 + " - larger number.");
    Console.WriteLine(number1 + " - smaller number.");
}
