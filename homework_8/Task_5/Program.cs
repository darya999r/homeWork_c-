// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int [,] matrix = new int [4,4];
int count = 0;
int i=0;
int j=0;

for (j=0; j<matrix.GetLength(1); j++)  //0 row
{
    matrix[i,j] = 1 + count; 
    count++;
}
        
for (i=1,j=3; i<matrix.GetLength(0); i++)  //3 column
{
    matrix[i,j] = 1 + count;
    count++;        
}

for (i=3,j=2; j>=0; j-=1)  //3 row
{
    matrix[i,j] = 1 + count;
    count++;        
}

for (j=0,i=2; i>=1; i-=1)  //0 column
{
    matrix[i,j] = 1 + count;
    count++;        
}

for (i=1,j=1; j<3; j++)  //1 row
{
    matrix[i,j] = 1 + count;
    count++;        
}
        
for (i=2,j=2; j>0; j-=1)  //2 row
{
    matrix[i,j] = 1 + count;
    count++;        
}
        
for (i=0; i<matrix.GetLength(0); i++)
{
    for (j=0; j<matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j] + "\t");
        
    }
    Console.WriteLine();
}



