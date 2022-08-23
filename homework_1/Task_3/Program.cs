//Задача 6
//Наришите прогармму, которая на вход принимает число и выдает,
//является ли число четным (делится ли оно на 2 без остатка).

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2==0)
{
    Console.WriteLine(number + " - even number.");//чётное число
}
else
{
    Console.WriteLine(number + " - odd number.");//нечётное число
}