// // 11 Напишите программу, которая
// выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

int DeliteSecondDigit(int num)
{
//    int firstDigit = num / 100;
//    int thirdDigit = num % 10;
//    int result = firstDigit * 10 + thirdDigit;
//     return result;
    int result = (number / 100) *10 + number % 10;
    return result;
}
int newNumber = DeliteSecondDigit(number);

Console.Write($"В числе {number} -> {newNumber}");