// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
/*
int rows = ReadInt("Enter count rows: ");
int colums = ReadInt("Enter count colums: ");
double[,] array = new double [rows, colums];
FillArrayRandomNumbers(array, 2, 10);
WriteArray(array);

void FillArrayRandomNumbers(double[,] array, int min, int max)
{
    Random rand = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        array[i,j] = Math.Round(rand.Next(min, max) + rand.NextDouble() , 1);
    }
}
void WriteArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int ReadInt(string messageMethod)
{
    Console.WriteLine(messageMethod);
    return Convert.ToInt32(Console.ReadLine());
}
 */
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
/*
int rows = ReadInt("Enter count rows: ");
int colums = ReadInt("Enter count colums: ");
int positionRow = ReadInt("Enter position row: ");
int positionColumn = ReadInt("Enter position column: ");
int[,] array = new int [rows, colums];

FillArrayRandomNumbers(array, 1, 10);
WriteArray(array);
FindPositionNumberArray(array, positionRow, positionColumn);

void FindPositionNumberArray(int[,] array, int row, int column)
{
    if(row > array.GetLength(0) && column > array.GetLength(1)) 
        Console.WriteLine("Position is not find");
    else 
        Console.WriteLine($"Result -> {array[row-1,column-1]}");
}
void FillArrayRandomNumbers(int[,] array, int min, int max)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max);
    }
}
void WriteArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int ReadInt(string messageMethod)
{
    Console.WriteLine(messageMethod);
    return Convert.ToInt32(Console.ReadLine());
}
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int rows = ReadInt("Enter count rows: ");
int colums = ReadInt("Enter count colums: ");
int[,] array = new int [rows, colums];

FillArrayRandomNumbers(array, 1, 10);
WriteArray(array);
Console.Write("Arithmetic mean rows: ");
ArithmeticMean(array);

void ArithmeticMean(int[,] array)
{
    double result = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        
        for(int j = 0; j < array.GetLength(0); j++)
        {
            result += array[j,i]; 
        }
        result = Math.Round(result / array.GetLength(0), 1);
        Console.Write($"{result}; ");
        result = 0;
    }
}
void FillArrayRandomNumbers(int[,] array, int min, int max)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max);
    }
}
void WriteArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int ReadInt(string messageMethod)
{
    Console.WriteLine(messageMethod);
    return Convert.ToInt32(Console.ReadLine());
}
