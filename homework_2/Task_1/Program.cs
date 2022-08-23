//Задача 10
//Напишите прогармму, которая на входе принимает трехзначное число
//и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100,1000);
Console.WriteLine("Random number: " + num);

int num1 = num/10;
int num2 = num1%10;

Console.WriteLine(num2);