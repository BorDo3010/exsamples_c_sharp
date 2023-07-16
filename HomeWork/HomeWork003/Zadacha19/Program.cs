﻿// Задача 19: Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.WriteLine("Введите пятизначное число: ");
string? i = Console.ReadLine();
int length = i.Length;

if (length == 5)
{
    if (i[0] == i[4] && i[1] == i[3])
    {
        Console.WriteLine($"Число: {i} - является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число: {i} - НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine($"Введённое число: {i} - не является пятизначным");
}
