﻿/*Задача 2: Напишите программу, которая на вход принимает два числа
и выдаёт, какое число большее, а какое меньшее.*/

Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("max = ");

if (a < b) {
    Console.Write(b);
} else {
    Console.Write(a);
}

Console.WriteLine();