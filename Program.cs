using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Оберіть операцію:");
        Console.WriteLine("1. Конвертувати з Фаренгейта в Цельсій");
        Console.WriteLine("2. Конвертувати з Цельсія в Фаренгейт");
        Console.Write("Ваш вибір: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Введіть температуру в градусах Фаренгейта: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Температура в градусах Цельсія: " + celsius);
        }
        else if (choice == 2)
        {
            Console.Write("Введіть температуру в градусах Цельсія: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Температура в градусах Фаренгейта: " + fahrenheit);
        }
        else
        {
            Console.WriteLine("Невірний вибір опції.");
        }
    }
}

