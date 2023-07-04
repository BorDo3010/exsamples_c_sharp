//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("max = ");

int m;

if (a < b) {
    m = b;
} else {
    m = a;
}
if (m < c) {
    Console.Write(c);
} else {
    Console.Write(m);
}

Console.WriteLine();