using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{

    public class Program
    {
        public static void Main(string[] args)
        {
            input();
        }
        static void input()
        {
            var calculator = new Calculator();

            Console.WriteLine("Simple Scientific Calculator");

          
            Console.WriteLine("Enter operation (add, sub, mul, div, sqrt, power, sin, cos, tan)");
            string operation = Console.ReadLine().ToLower();


            double result = 0;
            if (operation == "sqrt")
            {
                Console.WriteLine("Enter a number:");
                double number = Convert.ToDouble(Console.ReadLine());
                result = calculator.Sqrt(number);
            }
            else if (operation == "sin" || operation == "cos" || operation == "tan")
            {
                Console.WriteLine("Enter a number :");
                double number = Convert.ToDouble(Console.ReadLine());
                result = operation == "sine" ? calculator.Sin(number) : 
                         operation == "cosine" ? calculator.Cos(number) : calculator.Tan(number);
            }
            else
            {
                Console.WriteLine("Enter the first number:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                double b = Convert.ToDouble(Console.ReadLine());

                switch (operation)
                {
                    case "add":
                        result = calculator.Add(a, b);
                        break;
                    case "sub":
                        result = calculator.Sub(a, b);
                        break;
                    case "mul":
                        result = calculator.Mul(a, b);
                        break;
                    case "div":
                        result = calculator.Div(a, b);
                        break;
                    case "power":
                        result = calculator.Power(a, b);
                        break;
                    default:
                        Console.WriteLine("Unknown operation");
                        break;
                }
            }
            Console.WriteLine($"Result: {result}");
            
        }
    }


}
