// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = 3;
int columns = 4;

int [,] matrix = new int [rows,columns];

Console.WriteLine("Specified array: ");

for (int i=0; i<rows; i++)
{
    for (int j=0; j<columns; j++)
    {
        matrix[i,j] = new Random().Next(-10,11);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("New array: ");

for (int i=0; i<rows; i++)
{
    for (int j=0; j<columns; j++)
    {
        for (int h=0; h<(columns-1); h++)
        {
            if (matrix[i,h] < matrix[i,h+1])
            {
                int temp = matrix[i,h];
                matrix[i,h] = matrix[i,h+1];
                matrix[i,h+1] = temp;
            }
        }
        
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
