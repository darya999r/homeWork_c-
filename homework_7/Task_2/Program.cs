//Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


int rows = Convert.ToInt32(new Random().Next(0,10));
int columns = Convert.ToInt32(new Random().Next(0,10));
int [,] matrix = new int [rows,columns];

for (int i=0; i<rows; i++)
{
    for (int j=0; j<columns; j++)
    {
        matrix [i,j] = new Random().Next(-10,10);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.Write("Enter number line: ");             //i
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number column: ");           //j
int col = Convert.ToInt32(Console.ReadLine());

if (rows<line || columns<col) 
{
    Console.Write("There is no such number in the array!");
}
else
{
    Console.Write("Array element found: " + matrix[line-1,col-1]);
}

