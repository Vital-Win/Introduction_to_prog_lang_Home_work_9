// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"


void PrintNumber(int m, int n)
{
if (n>m)
for (int i = m; i <= n; i++)
    Console.Write($" {i}");
else
    for (int i = n; i <= m; i++)
        Console.Write($" {i}");
}


Console.WriteLine("Введите M");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите N");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Всё плохо");
}

PrintNumber(m, n);