using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)



        {
            while (true)

            {
                
                // ask for number
                Console.WriteLine("Enter num1: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                               
                if (num1 < 0)
                {
                    Console.WriteLine("Cannot Compute negative numbers.");
                    goto idk;
                }
                // asks what type of equation you want to do
                Console.Write("Enter operator(/,-,+,*): ");
                string? op = Console.ReadLine();

                
                //square root function
                if ( op == "square root")
                {
                    Console.WriteLine(Math.Sqrt(num1));
                    goto idk;
                }

                // asks for 2nd number
                Console.Write("Enter num2: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                                if (num2 < 0)
                {
                    Console.WriteLine("Cannot Compute negative numbers.");
                    goto idk;
                }
                
                if (num2 == 0 && op == "/")
                {
                    Console.WriteLine("Undefined");
                    goto idk;
                }
                {
                    //本当に翻訳に時間を費やしていますね

                    //all computer code has an error that 0.1 + 0.2= 0.30000000000000004
                    //this code changes that
                     if ( num1 == 0.1 && op == "plus" && num2 == 0.2 || num1 == 0.1 && op == "+" && num2 == 0.2)
                    {
                        Console.WriteLine("0.3");
                        goto idk;
                    }
                    {
                    }
                    }
                // does the math
                if (op == "+" || op == "plus")
                {
                    Console.WriteLine(num1 + num2);
                }
                else if (op == "-" || op == "minus")
                {
                    Console.WriteLine(num1 - num2);
                }
                else if (op == "/" || op == "divided by")
                {
                    Console.WriteLine(num1 / num2);
                }
                else if (op == "*" || op == "times" || op == "x")
                {
                    Console.WriteLine(num1 * num2);
                }
                else if (op == "to the power of")
                {
                    Console.WriteLine(Math.Pow(num1, num2));
                }
                else if (op == "squared") { 
                
                    Console.WriteLine(Math.Pow( num1, 2));
                }  
                else if (op == "cubed")
                {
                    Console.WriteLine(Math.Pow( num1, 3));
                }
                else
                {
                    Console.WriteLine("Please Enter a valad op next time");
                }

                // asks if you want to do another problem
                // "idk:" is used for the oto command and makes it so that tou dont have to run the code again if you mess up
                // you can look at alot of the code and see "goto idk;" this makes it skip to the loop code
                idk:
                Console.WriteLine("Do you want to do another problem");
                string? ny = Console.ReadLine();
                bool? yn = null;

                if (ny == "n")
                {
                    yn = false;
                }
                else if (ny == "y")
                {
                    yn = true;
                }
                else if (ny == "no")
                {
                    yn = false;
                }
                else if ( ny == "yes")
                {
                    yn = true;
                }

                if (yn == false)
                {
                    Console.WriteLine("ok");
                    return;
                }
                else if (yn == true)
                {
                    Console.WriteLine("\nEntering the Calculator");
                    while (true)
                        break;
                }



            }

        }
    }
}
