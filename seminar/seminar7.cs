// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
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
