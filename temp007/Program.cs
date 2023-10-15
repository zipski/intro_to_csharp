using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число A: ");
        string inputA = Console.ReadLine();
        
        Console.WriteLine("Введите степень B: ");
        string inputB = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(inputA) || string.IsNullOrWhiteSpace(inputB))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите числа.");
            return;
        }

        if (int.TryParse(inputA, out int A) && int.TryParse(inputB, out int B))
        {
            int result = Power(A, B);
            Console.WriteLine($"{A}^{B} = {result}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректные целые числа.");
        }
    }

    static int Power(int baseNumber, int exponent)
    {
        int result = 1;

        for (int i = 1; i <= exponent; i++)
        {
            result *= baseNumber;
        }

        return result;
    }
}

