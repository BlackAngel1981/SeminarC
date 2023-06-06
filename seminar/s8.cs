// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int rows = ReadInt("Enter count rows: ");
int colums = ReadInt("Enter count colums: ");
int[,] array = new int [rows, colums];
FillArrayRandomNumbers(array, 1, 10);
WriteArray(array);
SortArray(array);
WriteArray(array);

void SortArray(int[,] arraySort)
{
    int temp = 0, count = 0;
    for(int i = 0; i < arraySort.GetLength(0); i++)
    {
        while(count >= (-arraySort.GetLength(1)))
        {
            for(int j = 0; j < arraySort.GetLength(1)-1; j++)
            {
                if(arraySort[i,j] < arraySort[i,j+1]) 
                {
                    temp = arraySort[i,j];
                    arraySort[i,j] = arraySort[i,j+1];
                    arraySort[i,j+1] = temp;
                    count += 2;
                }
                else if(arraySort[i,j] > arraySort[i,j+1])
                {
                    count--;
                }
            }
        }
        count = 0;
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
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.
/*
int rows = ReadInt("Enter count rows: ");
int colums = ReadInt("Enter count colums: ");
int[,] array = new int [rows, colums];
int[] arrayResult = new int [array.GetLength(0)];
FillArrayRandomNumbers(array, 1, 10);
WriteArray(array);
SumArray(array,arrayResult);
Console.WriteLine("Number row with min sum elements: " + SortArray(arrayResult));

void SumArray(int[,] arrayForSum, int [] sum)
{
    for(int i = 0; i < arrayForSum.GetLength(0); i++)
    {
        for(int j = 0; j < arrayForSum.GetLength(1); j++)
        {
            sum[i] += arrayForSum[i,j];
        }
    }
}
int SortArray(int[] arrayReview)
{
    int minValue = arrayReview[0], row = 0;
    for(int i = 0; i < arrayReview.Length-1; i++)
    {
        if(minValue > arrayReview[i]) 
        {
            minValue = arrayReview[i];
            row = i + 1;
        }
    }
    return row;
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

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[] sizeMatrix = new int [4];
sizeMatrix[0] = ReadInt("Enter count rows for first matrix: ");
sizeMatrix[1] = ReadInt("Enter count colums for first matrix: ");
sizeMatrix[2] = ReadInt("Enter count rows for second matrix: ");
sizeMatrix[3] = ReadInt("Enter count colums for second matrix: ");
int[,] matrixFirst = new int [sizeMatrix[0], sizeMatrix[1]];
int[,] matrixSecond = new int [sizeMatrix[2], sizeMatrix[3]];

int[,] matrixFinal = new int [matrixFirst.GetLength(0), matrixSecond.GetLength(1)];

FillArrayRandomNumbers(matrixFirst, 1, 10);
FillArrayRandomNumbers(matrixSecond, 1, 10);
WriteArray(matrixFirst);
WriteArray(matrixSecond);
MultiplicationMatrix(matrixFirst,matrixSecond,matrixFinal);
WriteArray(matrixFinal);

void MultiplicationMatrix(int[,] arrayFirst, int [,] arraySecond, int[,] result)
{
    for(int k = 0; k < arraySecond.GetLength(1); k++)
    {
        for(int i = 0; i < arrayFirst.GetLength(0); i++)
        {
            for(int j = 0; j < arrayFirst.GetLength(1); j++)
                result[k,i] += arrayFirst[k,j] * arraySecond[j,i];
        }
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
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[] sizeArray = new int [3];
sizeArray[0] = ReadInt("Enter count plane: ");
sizeArray[1] = ReadInt("Enter count row: ");
sizeArray[2] = ReadInt("Enter count colums: ");
int[,,] array = new int [sizeArray[0],sizeArray[1],sizeArray[2]];

FillArrayRandomNumbers(array, 10, 100);
WriteArray(array);

void FillArrayRandomNumbers(int[,,] array, int min, int max)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int f = 0; f < array.GetLength(2); f++)
            {
                int[] index = {i, j, f};
                array[i, j, f] = GenerateRandomValue(array, min, max, index);
            }
        }
    }
}

int GenerateRandomValue(int [,,] array, int min, int max, int[] index)
{
    int number = 0;
    Random random = new Random();
    bool flag = true;
    while(flag)
    {
        number = random.Next(min, max);
        bool exit = false;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            if(exit == true) break;
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(exit == true) break;
                for(int f = 0; f < array.GetLength(2); f++)
                {
                    if(array[i,j,f] == number) 
                    {
                        //Console.WriteLine("Looking for" + array[i,j,f]);
                        exit = true;
                        break;
                    }
                    else if(i == index[0] && j == index[1] && f == index[2]) flag = false;
                }
            }
        }
    }
    return number;
}

void WriteArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int f = 0; f < array.GetLength(2); f++)
                Console.Write($"{array[i, j, f]} ({i}, {j}, {f}) ");
            Console.WriteLine();
        }
        //Console.WriteLine();
    }
}
int ReadInt(string messageMethod)
{
    Console.WriteLine(messageMethod);
    return Convert.ToInt32(Console.ReadLine());
}
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int size = ReadInt("Enter count rows/columns: ");
int[,] array = new int [size, size];
FillArrayNumbers(array);
WriteArray(array);

void FillArrayNumbers(int[,] array)
{
    int contentFull = array.GetLength(0) * array.GetLength(1);
    int counter = 0;
    int content = 1;
    int flag = 0;
    int hor = 0, ver = array.GetLength(1)-1;
    array[0,0] = content;

    while(content <= contentFull)
    {
        if (flag == 0)
        {
            for(int j = hor; j < ver; j++)
            {
                array[hor,j] = content ++;
            }
            flag ++;
            continue;
        }
        else if (flag == 1)
        {
            for(int i = hor; i < ver; i++)
            {
                array[i,ver] = content ++;
            }
            flag ++;
            continue;
        }
         if(flag == 2)
        {
            for(int j = ver; j >= hor; j--)
            {
                array[ver,j] = content ++;
            }
            ver --;
            flag ++;
            continue;
        }
        else if(flag == 3)
        {
            for(int i = ver; i > hor; i--)
            {
                array[i,hor] = content ++;
            }
            hor ++;
            flag ++;
            continue;
        }
        else if (flag > 3) flag = 0;
    }
}

void WriteArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] > 0 && array[i,j] < 10) Console.Write("0");
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int ReadInt(string messageMethod)
{
    Console.WriteLine(messageMethod);
    return Convert.ToInt32(Console.ReadLine());
}
