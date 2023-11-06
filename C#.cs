using System.IO;
using System;

class Program
{
    static void Main()
    {
        {
            while( true )

            {
               // ask for number
                Console.Write("Enter num1: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

 // make sure thres no negative, if there is the code stops
                if ( num1 < 0 ) {
                    Console.WriteLine("Cannot Compute negative numbers, please run again.");
                    return;
                }
               // asks what type of equation you want to do
                Console.Write("Enter operator(/,-,+,*): ");
                string op = Console.ReadLine();
                // asks for 2nd number
                Console.Write("Enter num2: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                
        // makes sure theres no negatives, if there is the code stops
if ( num2 < 0 ) {
                    Console.WriteLine("Cannot Compute negative numbers, please run again.");
                    return;
                } if ( num2 == 0 && op == "/"){ Console.WriteLine(" Cannot divide by 0") return; }
                    // does the math
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

                     // asks if you want to do another problem

                }
                Console.WriteLine(" do you want to do another sentance (y/n)");

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
