//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Enter M: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] array = GetArray (length);
Console.WriteLine("Numbers: " + String.Join(", ",array));
PositivNum(array);

int [] GetArray(int size)
{
    int[] res = new int [size];
    for(int i=0; i<size; i++)
    {
        Console.Write("Enter number" + (i+1) + ": ");
        res[i] = Convert.ToInt32(Console.ReadLine());

    }
    return res;
}

void PositivNum (int [] newArray)
{
    int count = 0;

    for(int i=0; i<newArray.Length; i++)
    {
        if (newArray[i] > 0)
        {
            count++;
        }
    }

    Console.WriteLine("Count of positiv numbers:" + count);
}
