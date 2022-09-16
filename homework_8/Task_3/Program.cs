// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows1 = new Random().Next(2,5);  //главное условие выполняется - квадратные матрицы!
int columns1 = rows1;
int rows2 = rows1;
int columns2 = columns1;

// int rows1 = new Random().Next(2,5);  //главное условие проверяется!
// int columns1 = new Random().Next(2,5);  //полностью рандомные матрицы
// int rows2 = new Random().Next(2,5);
// int columns2 = new Random().Next(2,5);

int [,] matrix1 = new int [rows1,columns1];
int [,] matrix2 = new int [rows2,columns2];
int [,] matrixNew = new int [rows1,columns2];

Console.WriteLine("Fierst array: ");
for (int i=0; i<rows1; i++)
{
    for (int j=0; j<columns1; j++)
    {
        matrix1[i,j] = new Random().Next(-9,10);
        Console.Write(matrix1[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine(string.Empty);

Console.WriteLine("Second array: ");
for (int i=0; i<rows2; i++)
{
    for (int j=0; j<columns2; j++)
    {
        matrix2[i,j] = new Random().Next(-9,10);
        Console.Write(matrix2[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine(string.Empty);

Console.WriteLine("New array: ");
if (rows1==columns2 && rows2==columns1)
{
    for (int i=0; i<rows1; i++)
    {
        for (int j=0; j<columns1; j++)
        {
            for (int h=0; h<rows1; h++)
            {
                matrixNew[i,j] += matrix1[i,h]*matrix2[h,j];
            }
            
            Console.Write(matrixNew[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
else Console.WriteLine("The power of two arrays is not possible!");

