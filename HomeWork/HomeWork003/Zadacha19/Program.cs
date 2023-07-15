// Задача 21: Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

//  AB = √ (x2 - x1) 2 + (y2 - y1) 2 Теорема Пифагора
            // AC ^ 2 + BC ^ 2

Console.Write("Введите координату по ои oX для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по ои oX для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по ои oX для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по ои oX для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
// Math.Sqrt(число) => Math.Sqrt(25) = 5 Sqrt = корень
// Math.Pow(числло и степень) => Math.Pow(2,3) Pow = степень
// Math.Round(число, кол-во знаков после запятой)
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
 
 