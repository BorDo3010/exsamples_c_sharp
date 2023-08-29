// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Write("Введите число: ");
// int limit = Convert.ToInt32(Console.ReadLine()); // Получили А 
// int sum = 0; // Суммы изначально нет
// // начало, условие, увеличение счетчика
// for (int i = 1; i <= limit; i++)
// {
//     sum += i;  // sum = sum + i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {limit} = {sum}");



// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); // Получили А 

// int count = 0; // Количество чисел 
// int copyNumber = number; // Копия числа number
// if (number != 0)
// {
//     while (number > 0)
//     {
//         count++; // Обнаружена 1 цифра,  count = count + 1
//         number /= 10; // number = number / 10
//     }
// }
// else
// {
//     count++; // Для 0 будет 1 цифра
// }

// Console.WriteLine($"В числе {copyNumber}: {count} цифр(ы)");


// ФИБОНАЧЧИ
// f(1) = 1
// f(2) =1
// f(n) = f(n - 1) + f(n - 2)


// double Fibonacci(int n)
// { 
//    if(n == 1 || n == 2) return 1;
//    else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine()); // Получили N
// int result = 1; // Умножив на 0, наши старания пропадут 
// // начало, условие, увеличение счетчика
// for (int i = 1; i <= N; i++)
// {
//     result *= i;  // result = result * i;
// }

// Console.WriteLine($"Факториал от числа {N} = {result}");


// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int size = 8;
// int[] array = new int[size]; // Массив на size элементов, на 8 элементов
// Изначально массив заполнен нулями.
// array.Length = size - длина массива(количество элементов) array = size
// for (int i = 0; i < array.Length; i++) // от 0 до 8 -> индексы: 0,1,2,3,4,5,6,7 
// {
    // array[i] = new Random().Next(0,2);
    // array[i] = new Random().Next(2); //Next(2) - начинаю с 0 и иду до 2: 0,1
    // Console.Write(array[i] + " ");
// }
// Массив печатается в цикле - способ №1 (90 строчка)

// Способ №2. Без цикла

// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");



// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }

// int[] SumPositiveNegativeElem(int[] arr)
// {
//     int sumPositive = 0;
//     int sumNegative = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sumPositive += arr[i];
//         else sumNegative += arr[i];
//     }

//     return new int[] { sumPositive, sumNegative };
// }

// int SumPositiveElem(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sum += arr[i];
//     }
//     return sum;
// }

// int SumNegativeElem(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0) sum += arr[i];
//     }
//     return sum;
// }

// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
// Console.WriteLine();

// int[] sumPositiveNegativeElem = SumPositiveNegativeElem(array);
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativeElem[0]}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativeElem[1]}");

// int sumPositiveElem = SumPositiveElem(array);
// int sumNegativeElem = SumNegativeElem(array);
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");


