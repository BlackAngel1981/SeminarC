//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int size = 5;
int[] array = new int [size];
int count = 0;
FillArrayRandomNumbers(array, 99, 1000);
WriteArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(array[i] %2 == 0)
    {
        count++;
    }
    else continue;
}
Console.WriteLine($"Quantity even count: {count}");

void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/* 
[-4, -6, 89, 6] -> 0 
int size = 5;
int[] array = new int [size];
int temp = 0;
FillArrayRandomNumbers(array, 0, 100);
WriteArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(i % 2 != 0)
    {
        temp += array[i];
    }
    else continue;
}
Console.WriteLine($"Sum odd count: {temp}");

void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и минимальным элементов массива.

int size = 5;
double[] array = new double [size];
double minArray = 100, maxArray = 0;
FillArrayRandomNumbers(array, Convert.ToInt32(maxArray), Convert.ToInt32(minArray));
WriteArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > maxArray) maxArray = array[i];
    else if(array[i] < minArray) minArray = array[i];
    else continue;
}
Console.WriteLine($"Max array = {maxArray} and Min array = {minArray}");
Console.WriteLine($"The difference between the numbers: {Math.Round(maxArray - minArray,1)}");

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArrayRandomNumbers(double[] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(rand.Next(min, max) + rand.NextDouble() , 1);
}