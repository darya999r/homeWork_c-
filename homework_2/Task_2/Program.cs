//Задача 13
//Напишите прогармму, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.

int num = new Random().Next(1,10000);
Console.WriteLine("Random number: " + num);

if(num<100)
{
    Console.WriteLine("There is no third number!");
}
if(num>=100 && num<1000)
{
    int num1 = num%10; 
    Console.WriteLine(num1);
}
if(num>=1000 && num<10000)
{
    int num1 = num/10;
    int num2 = num1%10; 
    Console.WriteLine(num2);
}


