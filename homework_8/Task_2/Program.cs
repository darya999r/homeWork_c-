// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = 3;
int columns = 4;
int [,] matrix = new int [rows,columns];

for (int i=0; i<rows; i++)
{
    for (int j=0; j<columns; j++)
    {
        matrix[i,j] = new Random().Next(-9,10);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine(string.Empty);

int sumNumRow = 0;
int sumNumRowMin = int.MaxValue;
int countRows = 0;

for (int i=0; i<rows; i++)
{
    for (int j=0; j<columns; j++)
    {
        sumNumRow += matrix[i,j];     
    }
    // Console.WriteLine(sumNumRow);
    if (sumNumRow < sumNumRowMin)
    {
        sumNumRowMin = sumNumRow;
        countRows = i+1;
    }
}
Console.WriteLine("Row number with the smallest sum of numbers: " + countRows);

