//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int num = new Random().Next(10000,100000);
//int num = 23432;
Console.WriteLine("Random number: " + num);

int num1 = num/10000;
int num2 = (num/1000)%10;
int num4 = (num/10)%10;
int num5 = num%10;

if(num1==num5 && num2==num4)
{
    Console.WriteLine("Polyndrome!");
}
else
{
    Console.WriteLine("Not polyndrome.");
}