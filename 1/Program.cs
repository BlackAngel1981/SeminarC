//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
/* 
Console.WriteLine("Eter numbers through ',':");
string? userNumbers = Console.ReadLine();
char symbol = ',';
int count = 0;

String[] strlist = userNumbers.Split(symbol, StringSplitOptions.RemoveEmptyEntries);
int[] arrayNumbers = new int[strlist.Length];

for(int i = 0; i < strlist.Length; i++)
{
    arrayNumbers[i] = Convert.ToInt32(strlist[i]);
    if(arrayNumbers[i] > 0) count++;
}

Console.WriteLine("[" + String.Join("->",arrayNumbers) + "]");
Console.WriteLine($"Count numbers > 0 = {count}");
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.



double b1 = ReadInt("Enter b1: ");
double k1 = ReadInt("Enter k1: ");
double b2 = ReadInt("Enter b2: ");
double k2 = ReadInt("Enter k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;

Console.WriteLine($" ->({x}; {y})");

double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}
