using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        if (!int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.WriteLine("Ошибка ввода для первого числа. Введите целое число.");
            return;
        }

        Console.Write("Введите второе число: ");
        if (!int.TryParse(Console.ReadLine(), out int num2))
        {
            Console.WriteLine("Ошибка ввода для второго числа. Введите целое число.");
            return;
        }

        Console.Write("Введите третье число: ");
        if (!int.TryParse(Console.ReadLine(), out int num3))
        {
            Console.WriteLine("Ошибка ввода для третьего числа. Введите целое число.");
            return;
        }

        int max = Math.Max(Math.Max(num1, num2), num3);

        Console.WriteLine($"Максимальное число: {max}");
    }
}
