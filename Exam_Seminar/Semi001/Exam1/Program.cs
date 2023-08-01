// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49


Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());
int square = numb * numb;
Console.WriteLine($"Квадрат числа {numb} = {square}");