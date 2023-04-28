using System;
using System.ComponentModel;

class Calculator
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Enter your expression (e.g. '2 + 3', or 'exit' to quit): ");
            string input = Console.ReadLine();

            if (input == "exit")
            {
                exit = true;
                continue;
            }

            string[] parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 3)
            {
                Console.WriteLine("Invalid expression.");
                continue;
            }

            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[2]);
            string op = parts[1];

            double result = 0;

            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = (double)a / b;
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    continue;
            }

            Console.WriteLine("The result: " + result);
        }
    }
}
