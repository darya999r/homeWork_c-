//Задача 8
//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

int numberN = new Random().Next(1,10);
Console.WriteLine("Random number: " + numberN);
int number = 2;

while(number<=numberN)
{
    Console.WriteLine(number);
    number+=2;
}
