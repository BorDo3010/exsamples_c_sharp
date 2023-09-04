// Задача 25: Напишите который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите число: ");

int limit = Convert.ToInt32(Console.ReadLine()); // Получили А 
int sum = 0; // Суммы изначально нет
// начало, условие, увеличение счетчика
for (int i = 1; i <= limit; i++)
{
    sum += i;  // sum = sum + i;
}
Console.WriteLine($"Сумма чисел от 1 до {limit} = {sum}");


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