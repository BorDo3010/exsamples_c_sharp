// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6   

Console.Write("Введите число : ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 100)
{
    Console.WriteLine("Проверьте написание числа!");
} 
else
{
    string str = userNumber.ToString();
Console.WriteLine($"Третья цифра числа {userNumber}: Это {str[2]}");
}
