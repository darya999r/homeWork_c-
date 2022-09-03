//Задача 29: Напишите программу, которая задаёт 
//массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33-> [1, 2, 5, 7, 19, 6, 1, 33]

int [] array = GetArray(8);
Console.WriteLine("Array: "+"[{0}]", string.Join(", ",array));

int [] GetArray(int size)
{
    int [] result = new int [size];
    for(int i=0; i<size; i++)
    {
        result[i] = new Random().Next(0,100);
    }
    Console.WriteLine("Elements: "+string.Join(", ",result));

    return result;
}

