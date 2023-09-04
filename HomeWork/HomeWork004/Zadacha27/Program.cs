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

while (true)
{
    Console.Write("Введите число: ");
    string userNumberText = Console.ReadLine();
    if (int.TryParse(userNumberText, out int userNumber))
    {
        Console.Clear();
        Console.WriteLine("Сумма цифр в числе {0} равняется {1}", userNumber, SumDigit(userNumber));
    }
    else
    { 
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}