// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
Console.Clear();

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("Введите неотрицательное число (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Ошибка. Введите число");
}
Console.WriteLine("Введите  неотрицательное число (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Ошибка. Введите число");
}

Console.WriteLine("Число Аккермана = " + Akkerman(m, n));
