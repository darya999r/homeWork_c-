﻿// Задача 68: Напишите программу вычисления 
//функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Enter number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number n: ");
int n = Convert.ToInt32(Console.ReadLine());

int FooAkkerman (int m, int n)
{
    if (m==0) return (n+1);
    if (n==0) return FooAkkerman(m-1,1);
    if (m>0 && n>0) return FooAkkerman(m-1,(FooAkkerman(m,n-1)));
    else return FooAkkerman(m,n);
}

Console.WriteLine("Ackermann function: " + FooAkkerman(m,n));
