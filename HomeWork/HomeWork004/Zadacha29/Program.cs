// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] RandomArray(int limit)
{
    int[] array = new int[limit];
    Random rand = new Random();
    for (int i = 0; i < limit; i++)
    {
        array[i] = rand.Next(1, 1000);
    }
    return array;
}

void PrintRanomArray(int limit)
{
    int[] randArray = RandomArray(limit);
    int count = randArray.Length;
    Console.Write("[");

    for (int i = 0; i < count; i++)
    {
        if (i == count - 1)
        {
            Console.Write($"{randArray[i]}");
        }
        else
        {
            Console.Write($"{randArray[i]}, ");
        }
    }
    Console.Write("]");

    Console.WriteLine();
}

Console.Clear();
while (true)
{
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("Для выхода Ctrl+C");
    Console.WriteLine("-------------------------------------------------");
    Console.Write("Введите размер массива: ");
    string userNumberText = Console.ReadLine();
    Console.Clear();
    if (int.TryParse(userNumberText, out int userNumber))
    {
        PrintRanomArray(userNumber);
    }
    else
    {
        Console.WriteLine($"Не удалось распознать число {userNumberText}, попробуйте еще раз.");
    }
}
