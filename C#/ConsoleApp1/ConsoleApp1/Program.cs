using System;
using ClassLibrary1;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Algebra alg = new Algebra();
            double number1 = 100;
            double number2 = 50;
            double result = alg.Addition(number1, number2);
            Console.Write(number1);
            Console.Write(" + ");
            Console.Write(number2);
            Console.Write(" = ");
            Console.WriteLine(result);
        }
    }
}
