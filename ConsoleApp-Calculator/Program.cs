using System;

namespace ConsoleApp_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator<int>();

            Console.WriteLine("Wpisz proszę dwie liczby oddzielone enterem: ");

            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Wpisz proszę działanie, które chcesz wykonać.");
            Console.WriteLine("Dostępne działania to: + - * /");

            var operation = Console.ReadLine();

            var result = default(int);

            switch (operation)
                {
                case "+":
                    {
                        result = calculator.Add(firstNumber, secondNumber);
                    } break;
                case "-":
                    {
                        result = calculator.Substract(firstNumber, secondNumber);
                    } break;
                case "*":
                    {
                        result = calculator.Multyply(firstNumber, secondNumber);
                    } break;
                case "/":
                    {
                        result = calculator.Divide(firstNumber, secondNumber);
                    } break;
            }

            Console.WriteLine(result);
        }
    }
}
