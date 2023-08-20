// // 11 Напишите программу, которая
// выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int randomNumbr = new Random().Next(100, 1000);
int result = (randomNumbr / 100) *10 + randomNumbr % 10;
Console.Write($"В числе {randomNumbr} -> {result}");