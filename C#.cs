using System.IO;
using System;

class Program
{
    static void Main()
    {
        {
            while( true )

            {

                Console.Write("Enter num1: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                if ( num1 < 0 ) {
                    Console.WriteLine("Cannot Compute negative numbers, please run again.");
                    return;
                }

                Console.Write("Enter operator(/,-,+,*): ");
                string op = Console.ReadLine();

                Console.Write("Enter num2: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                if ( num2 < 0 ) {
                    Console.WriteLine("Cannot Compute negative numbers, please run again.");
                    return;
                }

                if (op == "+") {
                    Console.WriteLine(num1 + num2);
                } else if (op == "-") {
                    Console.WriteLine(num1 - num2);
                } else if (op == "/") {
                    Console.WriteLine(num1 / num2);
                } else if (op == "*") {
                    Console.WriteLine(num1 * num2);
                } else {
                    Console.WriteLine("Invalid Operator");

                }
                Console.WriteLine(" do you want to do another sentance y/n");

                string yn = Console.ReadLine();
                if (yn == "y") {
                    Console.WriteLine("\nEntering the calculator.");
                    while(true)
                    break;
                } else if (yn == "n") {
                    Console.WriteLine("ok");
                    return;
                }
            }
        }
    }
}
