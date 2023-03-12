/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int m,n;
Console.Write($"Введите значение m: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите значение n: ");
int.TryParse(Console.ReadLine()!, out n);

Console.Write($"Сумма элементов от {m} до {n} = {PrintSum(m, n)}");

int PrintSum(int m, int n)
{
    if (m == n)
        return n;
    return n + PrintSum(m,n-1);
}
