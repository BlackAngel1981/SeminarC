// Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

int number = ReadInt("Enter N: ");
Console.Write($"N = {number}. -> '");
Console.WriteLine(NaturalNumber(number) + "'");

int NaturalNumber(int n)
{
    if (n == 1)
        return n;
    Console.Write(n + ", ");
    return NaturalNumber(n - 1);
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int numberM = ReadInt("Enter number M: ");
int numberN = ReadInt("Enter number N: ");
if (n > m)
    Console.WriteLine(SumNumbers(numberM, numberN));
else
    Console.WriteLine(SumNumbers(numberN, numberM));
int SumNumbers(int m, int n)
{
    if(m == n)
        return m;
    return m + SumNumbers(m + 1, n);
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

int numberM = ReadInt("Enter number M: ");
int numberN = ReadInt("Enter number N: ");
Console.WriteLine(Ack(numberM, numberN));
int Ack(int m, int n)
{
    if(m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ack(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ack(m - 1, Ack(m,n-1));
    else
        return m + 1;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
