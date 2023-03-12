/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int n;
Console.Write($"Введите число: ");
int.TryParse (Console.ReadLine()!, out n);

Console.Write(PrintNumbers(n));

string PrintNumbers(int n, int i=1)
{
    if (i>=n)
        return i.ToString();
    return $"{PrintNumbers(n,i+1)}, {i}";
}