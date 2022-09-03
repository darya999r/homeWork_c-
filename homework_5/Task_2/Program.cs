//Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int [] array = new int [5];
int length = array.Length;

int sum = 0;

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(-99,100);

    if (i%2 != 0)
    {
        int num = array[i];
        sum += num;
    }
}

Console.WriteLine("Array: " + "[{0}]", String.Join(", ", array));
Console.WriteLine("Sum: " + sum);