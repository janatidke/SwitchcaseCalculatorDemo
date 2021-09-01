using System;

namespace SwitchcaseCalculatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            float a, b, c;
            int d;
            Console.WriteLine("Enter first Operand");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Operand");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator");
            d = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Result of Calculation:");

            switch (d)
            {
                case'+':
                    c = a + b;
                    Console.WriteLine("{0}+{1}={2}", a, b, c);
                break;
                case '-':
                    c = a - b;
                    Console.WriteLine("{0}-{1}={2}", a, b, c);
                    break;
                case '*':
                    c = a * b;
                    Console.WriteLine("{0}*{1}={2}", a, b, c);
                    break;
                case '/':
                    c = a / b;
                    Console.WriteLine("{0}/{1}={2}", a, b, c);
                    break;
                case '%':
                    c = a + b;
                    Console.WriteLine("{0}%{1}={2}", a, b, c);
                    break;
                default:
                    Console.WriteLine("Invalid");
                break;


            }
        }   

    }
}
