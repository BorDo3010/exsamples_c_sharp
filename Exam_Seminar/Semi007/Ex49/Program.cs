﻿// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4



int[,] CreateMatrixSumIndexes(int rows, int columns,int min, int max) 
{ 
    int[,] matrix = new int[rows, columns]; 
    Random rand = new Random(); 
    for(int i = 0; i < rows; i++) 
    { 
        for(int j = 0; j < columns; j++) 
        { 
            matrix[i, j] = rand.Next(min,max+1); 
        } 
    } 
    return matrix; 
} 
 
void PrintArray(int[,] arr) 
{ 
    int rows = arr.GetLength(0); 
    int columns = arr.GetLength(1); 
 
    for(int i = 0; i < rows; i++) 
    { 
        for(int j = 0; j < columns; j++) 
        { 
            Console.Write($"{arr[i, j], 5}"); 
        } 
        Console.WriteLine(); 
    } 
} 
void EvenIndexesInSqare(int[,] matrix) 
{ 
    for(int i = 0; i < matrix.GetLength(0); i+=2) 
    { 
        for(int j = 0; j < matrix.GetLength(1); j+=2) 
        { 
            matrix[i, j] *= matrix[i, j]; 
        } 
    } 
} 
 
int[,] matrix = CreateMatrixSumIndexes(3, 4,2,10); 
PrintArray(matrix); 
EvenIndexesInSqare(matrix); 
Console.WriteLine(); 
PrintArray(matrix);