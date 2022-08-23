//Задача 15
//Напишите прогармму, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

Console.Write("Enter number day: ");
int numberDay = Convert.ToInt32(Console.ReadLine());


if(numberDay<1 || numberDay>7)
{
    Console.WriteLine("Error");
}
if(numberDay>=1 && numberDay<6)
{
    Console.WriteLine("Not a day off!");
}
if(numberDay==6)
{
    Console.WriteLine("Day off!!!");
}
if(numberDay==7)
{
    Console.WriteLine("Day off!!!");
}