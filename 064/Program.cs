// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""


Console.Clear();

int NaturalNumber(int m, int n)
{
    if (m == n)
        return m;
    else
        Console.Write($"{NaturalNumber(m, n - 1)}, ");
    return n;
}

Console.WriteLine("Введите число (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Ошибка. Введите число");
}

Console.WriteLine("Введите число (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Ошибка. Введите число");
}

Console.WriteLine(NaturalNumber(m, n));
