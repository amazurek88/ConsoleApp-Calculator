using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Calculator
{
    class Calculator<T>
    {
        public Calculator()
        {
            var example = default(T);
            var isInt = (example is int);
            var isFloat = (example is float);
            var isDouble = (example is double);

            if (isInt)
            {

            }
            else if (isFloat)
            {

            }
            else if (isDouble)
            {

            }
            else
            {
                Console.WriteLine("Zainicjowano kalkulator niepoprawnie!");
            }
        }

        public T Add(T first, T second)
        {
            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber + secondNumber;
        }

        public T Substract(T first, T second)
        {
            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber - secondNumber;
        }

        public T Multyply(T first, T second)
        {
            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber * secondNumber;
        }

        public int Divide(T first, T second)
        {
            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber / secondNumber;
        }
    }
}
