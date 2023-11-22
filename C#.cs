using System;
using System;


namespace calculator
{
    class Program
    {
        static void Main()
        {
            {
                while (true)

                {

                    // ask for number
                    Console.WriteLine("Enter num1: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    // make sure theres no negative, if there is the code stops
                    if (num1 < 0)
                    {
                        Console.WriteLine("Cannot Compute negative numbers, please run again.");
                        return;
                    }
                    // asks what type of equation you want to do
                    Console.Write("Enter operator(/,-,+,*): ");
                    string? op = Console.ReadLine();

                    // adds a squared option(would have it loop but i cant get it to work)
                    if (op == "squared")
                    {
                        Console.WriteLine(num1 * num1);
                        Console.WriteLine("please run again");
                        return;
                    }
                    else if (op == "cubed")
                    {
                        Console.WriteLine(num1 * num1 * num1);
                        Console.WriteLine("Please run again");
                        return;
                    }
                    // asks for 2nd number
                    Console.Write("Enter num2: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    // makes sure theres no negatives, if there is the code stops
                    if (num2 < 0)
                    {
                        Console.WriteLine("Cannot Compute negative numbers, please run again.");
                        return;
                    }
                    if (num2 == 0 && op == "/")
                    {
                        Console.WriteLine(" Cannot divide by 0 please run again");
                        return;
                    }
                    // does the math
                    if (op == "+")
                    {
                        Console.WriteLine(num1 + num2);
                    }
                    else if (op == "-")
                    {
                        Console.WriteLine(num1 - num2);
                    }
                    else if (op == "/")
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    else if (op == "*")
                    {
                        Console.WriteLine(num1 * num2);
                    }
                    else if (op == "times")
                    {
                        Console.WriteLine(num1 * num2);
                    }
                    else if (op == "minus")
                    {
                        Console.WriteLine(num1 - num2);
                    }
                    else if (op == "plus")
                    {
                        Console.WriteLine(num1 + num2);
                    }
                    else if (op == "divided by")
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    else if (op == "x")
                    {
                        Console.WriteLine(num1 * num2);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operator");
                    }
                    // asks if you want to do another problem


                    

                    Console.WriteLine("Do you want to do another problem");
                    string? ny = Console.ReadLine();
                    bool? yn = null;

                    if (ny == "n")
                    {
                        yn = false;
                    } else if ( ny == "y")
                    {
                        yn = true;
                    }

                    if (yn == false)
                    {
                        Console.WriteLine("ok");
                        return;
                    } else if ( yn == true)
                    {
                        Console.WriteLine("\nEntering the Calculator");
                        while (true)
                            break;
                    }


                    

                }

            }
        }
    }

}
