using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static 김의성_플밍1기__클래스와_Static.Program;

namespace 김의성_플밍1기__클래스와_Static
{
    internal class Program
    {
        public class MyCalculator
        {
            public static double Add(double a, double b)
            {
                return a + b;
            }
            public static double Subtract(double a, double b)
            {
                return a - b;
            }
            public static double Multiply(double a, double b)
            {
                return a * b;
            }
            public static double Divide(double a, double b)
            {
                if (b == 0)
                {
                    Console.WriteLine("0으로 나눌수 없습니다.");
                    return 0;
                }
                return a / b;
            }
            public static double Squared(double a, double b)
            {
                return Math.Pow(a, b);
            }
        }
        static void Main(string[] args)
        {
            double a = 20;
            double b = 10;

            
            Console.WriteLine($"Add {MyCalculator.Add(a, b)}");
            Console.WriteLine($"Subtract {MyCalculator.Subtract(a, b)}");
            Console.WriteLine($"Multiply {MyCalculator.Multiply(a, b)}");
            Console.WriteLine($"Divide {MyCalculator.Divide(a, b)}");
            Console.WriteLine($"Squared {MyCalculator.Squared(a, b)}");
        }
    }
}
