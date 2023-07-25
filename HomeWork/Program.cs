// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Матрица - прямоугольная таблица размером m(строчки) на n(cтолбцов)

int[,] result = GetMatrix(3, 4, 0, 10);
// таблица 3 на 4, числа: от 0 до 10 включительно
PrintMatrix(result);
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n]; // [кол-во_строк, кол-во_столбцов]
    for (int i = 0; i < matrix.GetLength(0); i++) // m, цикл по строчкам
    {
        // i, k, m, n, j
        for (int j = 0; j < matrix.GetLength(1); j++)// n, цикл по столбцам
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // m, цикл по строчкам
    {
        // i, k, m, n, j
        for (int j = 0; j < matrix.GetLength(1); j++)// n, цикл по столбцам
        {
            Console.Write(matrix[i, j] + "\t"); // Tab между элементами матрицы
        }
        Console.WriteLine();
    }
}
// PascalCase - методы 
// camelCase - переменные и массивы
void ChangeRows(int[,] matr)
{
    int lastRowIndex = matr.GetLength(0) - 1; // Номер последней строчки
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        int temp = matr[0, i]; // temp = matr[0,0] => temp = 1
        matr[0, i] = matr[lastRowIndex, i]; // matr[0, 0] = matr[2, 0] => matr[0, 0] = 7
        matr[lastRowIndex, i] = temp; // matr[2, 0] = temp
    }
}
Console.WriteLine("Поменяли 1 и последнюю строчку местами");
ChangeRows(result);
PrintMatrix(result); // Видоизмененная матрица (поменяли 1 и последнюю строчку)