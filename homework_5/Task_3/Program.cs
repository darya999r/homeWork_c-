//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.
//[3 7 22 2 78] -> 76

int [] array = new int [5];
int max = int.MinValue;
int min = int.MaxValue;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);

    if (array[i] > max)
    {
        max = array[i];
    }

    if (array[i] < min)
    {
        min = array[i];
    }

}

int diff = max - min;

Console.WriteLine("Array: " + "[{0}]", String.Join(", ", array));
Console.WriteLine("Maximal element: " + max);
Console.WriteLine("Minimal element: " + min);
Console.WriteLine("Difference between max and min: " + diff);
