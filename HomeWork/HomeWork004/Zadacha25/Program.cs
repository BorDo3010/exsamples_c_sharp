// Задача 25: Напишите который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double RaiseDegree(double number, int degree)
{
    double pow = Math.Pow(number, degree);
    return pow;
}

Console.Clear();
while (true)
{
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("Для выхода Ctrl+C");
    Console.WriteLine("-------------------------------------------------");
    Console.Write("Введите число: ");
    string userNumberText = Console.ReadLine();
    Console.Write("Введите степень: ");
    string userDegreeText = Console.ReadLine();
    Console.Clear();
    if (int.TryParse(userDegreeText, out int userDegree) && double.TryParse(userNumberText, out double userNumber))
    {
        Console.WriteLine($"Сумма цифр в числе {userNumber} равняется {RaiseDegree(userNumber, userDegree)}");
    }
    else
    {
        Console.WriteLine($"Не удалось распознать число {userNumberText}, попробуйте еще раз.");
    }
}
