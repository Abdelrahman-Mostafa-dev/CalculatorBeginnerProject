using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CalculatorBegginerProject
{
    class Calc
    {

        static public void Add()
        {
            Console.WriteLine("Please specify the first input");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Please specify the second input");
            string secondInput = Console.ReadLine();
            int num1;
            int num2;
            bool IsFirstinputparsable = Int32.TryParse(firstInput, out num1);
            bool IsSecondinputparsable = Int32.TryParse(secondInput, out num2);
            if (IsFirstinputparsable && IsSecondinputparsable)
            {
                int result = num1 + num2;
                Console.WriteLine($"The result of {num1} and {num2} is {result}");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsSecondinputparsable && !IsFirstinputparsable)
            {
                Console.WriteLine("The inputs are not a number");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsFirstinputparsable)
            {
                Console.WriteLine("The first input is not a number!");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsSecondinputparsable)
            {
                Console.WriteLine("The second input is not a number!");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static public void Subtraction()
        {
            Console.WriteLine("Please specify the first input");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Please specify the second input");
            string secondInput = Console.ReadLine();
            int num1;
            int num2;
            bool IsFirstinputparsable = Int32.TryParse(firstInput, out num1);
            bool IsSecondinputparsable = Int32.TryParse(secondInput, out num2);
            if (IsFirstinputparsable && IsSecondinputparsable)
            {
                int result = num1 - num2;
                Console.WriteLine($"The result of {num1} and {num2} is {result}");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsSecondinputparsable && !IsFirstinputparsable)
            {
                Console.WriteLine("The inputs are not a number");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsFirstinputparsable)
            {
                Console.WriteLine("The first input is not a number!");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsSecondinputparsable)
            {
                Console.WriteLine("The second input is not a number!");
                Console.ReadLine();
                Console.Clear();
            }


        }
        static public void Multiply()
        {
            Console.WriteLine("Please specify the first input");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Please specify the second input");
            string secondInput = Console.ReadLine();
            int num1;
            int num2;
            bool IsFirstinputparsable = Int32.TryParse(firstInput, out num1);
            bool IsSecondinputparsable = Int32.TryParse(secondInput, out num2);
            if (IsFirstinputparsable && IsSecondinputparsable)
            {
                int result = num1 * num2;
                Console.WriteLine($"The result of {num1} and {num2} is {result}");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsSecondinputparsable && !IsFirstinputparsable)
            {
                Console.WriteLine("The inputs are not a number");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsFirstinputparsable)
            {
                Console.WriteLine("The first input is not a number!");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsSecondinputparsable)
            {
                Console.WriteLine("The second input is not a number!");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static public void Division()
        {
            Console.WriteLine("Please specify the first input");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Please specify the second input");
            string secondInput = Console.ReadLine();
            int num1;
            int num2;
            bool IsFirstinputparsable = Int32.TryParse(firstInput, out num1);
            bool IsSecondinputparsable = Int32.TryParse(secondInput, out num2);
            if (IsFirstinputparsable && IsSecondinputparsable)
            {
                int result = num1 / num2;
                Console.WriteLine($"The result of {num1} and {num2} is {result}");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsSecondinputparsable && !IsFirstinputparsable)
            {
                Console.WriteLine("The inputs are not a number");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsFirstinputparsable)
            {
                Console.WriteLine("The first input is not a number!");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsSecondinputparsable)
            {
                Console.WriteLine("The second input is not a number!");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static public void Exponent()
        {
            Console.WriteLine("Please specify the first input");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Please specify the second input");
            string secondInput = Console.ReadLine();
            int num1;
            int num2;
            bool IsFirstinputparsable = Int32.TryParse(firstInput, out num1);
            bool IsSecondinputparsable = Int32.TryParse(secondInput, out num2);
            if (IsFirstinputparsable && IsSecondinputparsable)
            {
                int result = (int)Math.Pow(num1, num2);
                Console.WriteLine($"The result of {num1} and {num2} is {result}");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsSecondinputparsable && !IsFirstinputparsable)
            {
                Console.WriteLine("The inputs are not a number");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsFirstinputparsable)
            {
                Console.WriteLine("The first input is not a number!");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsSecondinputparsable)
            {
                Console.WriteLine("The second input is not a number!");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static public void SquareRoot()
        {
            Console.WriteLine("Please specify the first input");
            string firstInput = Console.ReadLine();
            int num1;
            bool IsFirstinputparsable = Int32.TryParse(firstInput, out num1);
            if (IsFirstinputparsable)
            {
                int result = (int)Math.Sqrt(num1);
                Console.WriteLine($"The SquareRoot of {num1} is {result}");
                Console.ReadLine();
                Console.Clear();
            }
            else if (!IsFirstinputparsable)
            {
                Console.WriteLine("The first input is not a number!");
                Console.ReadLine();
                Console.Clear();
            }
        }

    }
}

