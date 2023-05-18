using System;

namespace MultiFunctionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите тип функции: ");
                Console.WriteLine("1 - Калькулятор, 2 - Генератор случайных чисел, 3 - Конвертер температуры, 4 - Калькулятор расходов");
                int functionType = Convert.ToInt32(Console.ReadLine());

                switch (functionType)
                {
                    case 1:
                        Calculator();
                        break;
                    case 2:
                        RandomNumberGenerator();
                        break;
                    case 3:
                        TemperatureConverter();
                        break;
                    case 4:
                        ExpenseCalculator();
                        break;
                    default:
                        Console.WriteLine("Неверный тип функции.");
                        break;
                }

                Console.WriteLine("Выполнить еще одну функцию? Y/N");
                string repeat = Console.ReadLine().ToLower();
                if (repeat == "n")
                {
                    break;
                }
            }
        }

        static void Calculator()
        {
            double num1, num2;
            Console.WriteLine("Введите первое число: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию: +, -, *, /");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.WriteLine($"Результат: {num1 + num2}");
            }
            else if (operation == "-")
            {
                Console.WriteLine($"Результат: {num1 - num2}");
            }
            else if (operation == "*")
            {
                Console.WriteLine($"Результат: {num1 * num2}");
            }
            else if (operation == "/")
            {
                Console.WriteLine($"Результат: {num1 / num2}");
            }
        }

        static void RandomNumberGenerator()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101);
            Console.WriteLine($"Случайное число: {randomNumber}");
        }

        //static void TemperatureConverter()
        //{
        //    Console.WriteLine("Выберите тип конвертации: C - Фаренгейт в Цельсий, F - Цельсий в Фаренгейт");
        //    string conversionType = Console.ReadLine();

        //    if (conversionType == "C")
        //    {
        //        Console.WriteLine("Введите значение в градусах Фаренгейта: ");
        //        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        //        double celsius = (fahrenheit - 32) * 5 / 9;
        //        Console.WriteLine($"Результат: {celsius} градусов Цельсия");
        //    }
        //    else if (conversionType == "F")
        //    {
        //        Console.WriteLine("Введите значение в градусах Цельсия: ");
        //        double celsius = Convert.ToDouble(Console.ReadLine());
        //        double fahrenheit = (celsius * 9 / 5) + 32;
        //        Console.WriteLine($"Результат: {fahrenheit} градусов Фаренгейта");
        //    }
        //}

        //static void ExpenseCalculator()
        //{
        //    Console.WriteLine("Введите бюджет: ");
        //    double budget = Convert.ToDouble(Console.ReadLine());

        //    double totalExpenses = 0;
        //    while (true)
        //    {
        //        Console.WriteLine("Введите расход: ");
        //        double expense = Convert.ToDouble(Console.ReadLine());
        //        totalExpenses += expense;

        //        if (totalExpenses >= budget)
        //        {
        //            Console.WriteLine("Вы исчерпали бюджет!");
        //            break;
        //        }

        //        Console.WriteLine($"Ваш текущий бюджет: {budget - totalExpenses}");
        //    }
        //}
    }
}
