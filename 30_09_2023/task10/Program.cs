using System;

partial class Program
{
    static void Main()
    {
        Console.Write("Пожалуйста, введите трёхзначное число: ");
        string input = Console.ReadLine();

        if (input.Length != 3)
        {
            Console.WriteLine("Вы ввели некорректное число. Пожалуйста, введите трёхзначное число.");
        }
        else
        {
            try
            {
                int number = int.Parse(input);
                int secondDigit = (number / 10) % 10;
                
                Console.WriteLine($"Вторая цифра введенного числа: {secondDigit}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели некорректное число. Пожалуйста, введите трёхзначное число.");
            }
        }
    }
}


