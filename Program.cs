using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a calculator function. You, the user, enters a number, then hit enter. Then enter an operator (+,-,*,/) and hit enter. Then another number. You can continue to enter numbers, or you can type an = and hit enter to get your result. Have fun.");
            Console.WriteLine("There's no input checking, so you do have to enter proper values or it won't work :(");
            Console.WriteLine("Also can't return decimals. Maybe that's what I'll work on in the future when I know more about C#.");
            Console.ReadLine();
            Console.WriteLine("First value: ");
            string input = Console.ReadLine();

            var keyStrokes = new List<string>();
            while(input != "=")
            {
                keyStrokes.Add(input);
                Console.WriteLine("Next value: ");
                input = Console.ReadLine();
            }

            string[] final = keyStrokes.ToArray();
            string change = final[0];

            for(int i = 0; i < final.Length; i++)
            {
                if(final[i] == "+")
                    final[i + 1] = Add(Int32.Parse(final[i - 1]), Int32.Parse(final[i + 1])).ToString();
                if (final[i] == "-")
                    final[i + 1] = Subtract(Int32.Parse(final[i - 1]), Int32.Parse(final[i + 1])).ToString();
                if (final[i] == "*")
                    final[i + 1] = Multiply(Int32.Parse(final[i - 1]), Int32.Parse(final[i + 1])).ToString();
                if (final[i] == "/")
                    final[i + 1] = Divide(Int32.Parse(final[i - 1]), Int32.Parse(final[i + 1])).ToString();
            }

            Console.WriteLine("Your answer is: {0}", final[final.Length - 1]);
            Console.ReadLine();
        }

        static int Add(int val1, int val2)
        {
            return val1 + val2;
        }
        static int Subtract(int val1, int val2)
        {
            return val1 - val2;
        }
        static int Multiply(int val1, int val2)
        {
            return val1 * val2;
        }
        static int Divide(int val1, int val2)
        {
            return val1 / val2;
        }
    }
}
