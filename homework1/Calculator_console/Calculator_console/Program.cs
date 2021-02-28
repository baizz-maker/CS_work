using System;

namespace Calculator_console
{
    class Program
    {   

        static void Main(string[] args)
        {
            string text;
            int num1;
            int num2;
            char calculate;
            Console.WriteLine("Input the first number:");
            text = Console.ReadLine();
            num1 = int.Parse(text);
            Console.WriteLine("Input the second number:");
            text = Console.ReadLine();
            num2 = int.Parse(text);
            Console.WriteLine("Input the operator:");
            text = Console.ReadLine();
            switch (text)
            {
                case "+":
                    Console.WriteLine("The result is:  " + ( num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("The result is:  " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("The result is:  " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("The result is:  " + (num1 / num2));
                    break;

            }

            Console.ReadKey();



        }
    }
}
