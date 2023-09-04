// Задача 27: Напишите программу, которая принимает на
//  вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigit(int numb)
{
    int sum = 0;

    while (numb != 0)
    {
        sum = sum + numb % 10;
        numb = numb / 10;
    }
    return sum;
}

Console.Clear();
while (true)
{
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("Для выхода Ctrl+C");
    Console.WriteLine("-------------------------------------------------");
    Console.Write("Введите число: ");
    string userNumberText = Console.ReadLine();
    Console.Clear();
    if (int.TryParse(userNumberText, out int userNumber))
    {
        Console.WriteLine($"Сумма цифр в числе {userNumber} равняется {SumDigit(userNumber)}");
    }
    else
    {
        Console.WriteLine($"Не удалось распознать число {userNumberText}, попробуйте еще раз.");
    }
}
