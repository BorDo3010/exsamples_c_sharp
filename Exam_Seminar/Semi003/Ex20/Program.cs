﻿// Задача 20: Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

//  AB = √ (x2 - x1) 2 + (y2 - y1) 2 Теорема Пифагора
            // AC ^ 2 + BC ^ 2

// Math.Sqrt(число) => Math.Sqrt(25) = 5 Sqrt = корень
// Math.Pow(числло и степень) => Math.Pow(2,3) Pow = степень
// Math.Round(число, кол-во знаков после запятой)

// double sqrt = Math.Sqrt(5);
// double pow = Math.Pow(5, 3);

// double d = 5.0998322; // 5.09
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(dRound);
// Console.WriteLine($"{d:F2}");
 // 20. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double FindDistance(int xA, int yA, int xB, int yB)
{
    return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
}

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateB = Convert.ToInt32(Console.ReadLine());

double result = FindDistance(xCoordinateA, yCoordinateA, xCoordinateB, yCoordinateB);
Console.WriteLine($"Расстояние между точками -> {Math.Round(result, 2, MidpointRounding.ToZero)}");