using System;
using System.Runtime.ExceptionServices;

namespace CalculatorBegginerProject
{
    class Program
    {   
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Title =  "Calculator";
                string headText = "Please specify the operation";
                Console.SetCursorPosition((Console.WindowWidth - headText.Length) / 2, 0);
                Console.WriteLine(headText);
                Console.WriteLine("1.Addition \n2.Subtraction\n3.Multiplication\n4.Division\n5.Exponent\n6.SquareRoot");
                string operation = Console.ReadLine();
                if (operation == "1")
                {
                    Calc.Add();
                }
                else if (operation == "2")
                {
                    Calc.Subtraction();
                }
                else if (operation == "3")
                {
                    Calc.Multiply();
                }
                else if (operation == "4")
                {
                    Calc.Division();
                }
                else if (operation == "5")
                {
                    Calc.Exponent();
                }
                else if (operation == "6")
                {
                    Calc.SquareRoot();
                }
                else
                {
                    Console.WriteLine("Please specify a valid operation");
                    Console.ReadLine();
                    Console.Clear();
                }


                

                }
            }
        }
    }

