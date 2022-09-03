//Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int [] array = new int [5];
int length = array.Length;
int count = 0;

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(100,1000);
    
    int num = array[i];
    if (num%2 == 0)
    {
        count++;
    }
}

Console.WriteLine("Array: "+"[{0}]", String.Join(",", array));
Console.WriteLine("Even numbers: " + count);