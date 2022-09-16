//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int rows = Convert.ToInt32(new Random().Next(0,10));
int columns = Convert.ToInt32(new Random().Next(0,10));
double [,] matrix = new double [rows,columns];

for (int i=0; i<rows; i++)
{
    for (int j=0; j<columns; j++)
    {
        matrix [i,j] = new Random().Next(-10,10);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.Write("Average of numbers in column: ");
for (int j=0; j<columns; j++)
{
    double sumNumColumn = 0;
    for (int i=0; i<rows; i++)
    {
        sumNumColumn += matrix[i,j];
    }
    Console.Write($"{Math.Round(sumNumColumn/rows, 2)}" + "; ");
}

