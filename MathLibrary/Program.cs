using System;

namespace MathLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            //practice with creating static methods

            //var math = new Math();
            var answer = Math.Addition(1, 2);
            Console.WriteLine($" 1 + 2 = {answer}");

            answer = Math.Subtraction(7, 2);
            Console.WriteLine($" 7 - 2 = {answer}");

            answer = Math.Multiplication(3, 2);
            Console.WriteLine($" 3 X 2 = {answer}");

            answer = Math.Division(10, 5);
            Console.WriteLine($" 10 / 5 = {answer}");

            answer = Math.Modulo(7, 2); // should return 1
            Console.WriteLine($" 7 % 2 = {answer}");

            answer = Math.Modulo(13, 5); // should return 3
            Console.WriteLine($" 13 % 5 = {answer}");

            answer = Math.Modulo(1234, 13); // should return 12
            Console.WriteLine($" 1234 % 13 = {answer}");

            answer = Math.Power(13, 3); //2197
            Console.WriteLine($" 13 ^ 3 = {answer}");

            var i = 98;
            var boolAnswer = Math.isEven(i);
            Console.WriteLine($" {i} is {(boolAnswer ? "Even" : "Odd")}");

            i = 0;
            var inc = Math.Inc(i);
            var dec = Math.Dec(i);
            Console.WriteLine($" {i} incremented {Math.Inc(i)}");
            Console.WriteLine($" {i} decremented {Math.Dec(i)}");

        }
    }
}
