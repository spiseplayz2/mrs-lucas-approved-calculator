
using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)



        {
            while (true)

            {
            start:
                // ask for number
                Console.WriteLine("\nEnter num1: ");

                       double num1 = Convert.ToDouble(Console.ReadLine());

                if (num1 < 0)
                {
                    Console.WriteLine("Cannot Compute negative numbers.");
                    goto rerun;
                }
                // asks what type of equation you want to do
                Console.Write("Enter operator(/,-,+,*): ");
                string? op = Console.ReadLine();


                //square root function
                if (op == "square root")
                {
                    Console.WriteLine(Math.Sqrt(num1));
                    goto rerun;
                }

                // asks for 2nd number
                Console.Write("Enter num2: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                if (num2 < 0)
                {
                    Console.WriteLine("Cannot Compute negative numbers.");
                    goto rerun;
                }

                if (num2 == 0 && op == "/")
                {
                    Console.WriteLine("Undefined");
                    goto rerun;
                }

                //本当に翻訳に時間を費やしていますね
                Console.WriteLine("Num3?");
                string? n3 = Console.ReadLine();

                if (n3 == "yes" || n3 == "y")
                {
                    goto n3;
                }
                else if (n3 == "no" || n3 == "n")
                {
                    goto math;
                } else
                {
                    goto math;
                }

                {
                    //all computer code has an error that 0.1 + 0.2= 0.30000000000000004
                    //this code changes that
                    if (num1 == 0.1 && op == "plus" && num2 == 0.2 || num1 == 0.1 && op == "+" && num2 == 0.2)
                    {
                        Console.WriteLine("0.3");
                        goto rerun;
                    }
                }
            // adds a third number
            n3:



                Console.WriteLine("Enter 2nd op: ");
                string? op2 = Console.ReadLine();
                Console.WriteLine("Enter num3: ");
                double num3 = Convert.ToDouble(Console.ReadLine());
                if (num3 < 0)
                {
                    Console.WriteLine("Cannot compute negative numbers, try again");
                    goto rerun;
                }




                // adds a 4th number(i want to die)
                if (n3 == "yes" || n3 == "y")
                {
                    Console.WriteLine("num4?");

                }
                string? n4 = Console.ReadLine();

                if (n4 == "yes" || n4 == "y")
                {
                    goto n4;
                }
                else if (n4 == "n" || n4 == "no")
                {
                    goto math2;
                }

            n4:

                Console.WriteLine("Enter a 3rd op: ");
                string? op3 = Console.ReadLine();

                Console.WriteLine("Enter num4: ");
                double num4 = Convert.ToDouble(Console.ReadLine());



                if (op == "+" && op2 == "+" && op3 == "+" || op == "plus" && op2 == "plus" && op3 == "plus" || op == "+" && op2 == "+" && op3 == "plus" || op == "+" && op2 == "plus" && op3 == "+" || op == "plus" && op2 == "+" && op3 == "+" || op == "plus" && op2 == "plus" && op3 == "+" || op == "plus" && op2 == "+" && op3 == "plus")
                {
                    Console.WriteLine(num1 + num2 + num3 + num4);
                    goto rerun;
                }
                else if (op == "-" && op2 == "-" && op3 == "-" || op == "minus" && op2 == "minus" && op3 == "minus" || op == "-" && op2 == "-" && op3 == "minus" || op == "-" && op2 == "minus" && op3 == "-" || op == "minus" && op2 == "-" && op3 == "-" || op == "minus" && op2 == "minus" && op3 == "-" || op == "minus" && op2 == "-" && op3 == "minus")
                {
                    Console.WriteLine(num1 - num2 - num3 - num4 );
                    goto rerun;
                }
                else if (op == "/" && op2 == "/" && op3 == "/" || op == "divided by" && op2 == "divided by" && op3 == "divided by" || op == "/" && op2 == "/" && op3 == "divided by" || op == "/" && op2 == "divided by" && op3 == "/" || op == "divided by" && op2 == "/" && op3 == "/" || op == "divided by" && op2 == "divided by" && op3 == "/" || op == "divided by" && op2 == "/" && op3 == "divided by")
                {
                    Console.WriteLine(num1 / num2 / num3 / num4 );
                    goto rerun;
                }
                else if (op == "x" && op2 == "x" && op3 == "x" || op == "*" && op2 == "*" && op3 == "*" || op == "times" && op2 == "times" && op3 == "times" || op == "x" && op2 == "x" && op3 == "times" || op == "x" && op2 == "times" && op3 == "x" || op == "times" && op2 == "x" && op3 == "x" || op == "x" && op2 == "times" && op3 == "*" || op == "x" && op2 == "x" && op3 == "*" || op == "x" && op2 == "*" && op3 == "x" || op == "x" && op2 == "*" && op3 == "*" || op == "x" && op2 == "*" && op3 == "times" || op == "x" && op2 == "times" && op3 == "times" || op == "times" && op2 == "times" && op3 == "x" || op == "times" && op2 == "times" && op3 == "*" || op == "times" && op2 == "x" && op3 == "*" || op == "times" && op2 == "x" && op3 == "times" || op == "times" && op2 == "*" && op3 == "x" || op == "times" && op2 == "*" && op3 == "*" || op == "times" && op2 == "*" && op3 == "times" || op == "*" && op2 == "*" && op3 == "times" || op == "*" && op2 == "*" && op3 == "x" || op == "*" && op2 == "x" && op3 == "times" || op == "*" && op2 == "x" && op3 == "*" || op == "*" && op2 == "x" && op3 == "x" || op == "*" && op2 == "times" && op3 == "times" || op == "*" && op2 == "times" && op3 == "*" || op == "*" && op2 == "times" && op3 == "x")
                {
                    Console.WriteLine(num1 * num2 * num3 * num4 );
                    goto rerun;
                }
                else if (op == "+" && op2 == "+" && op3 == "-" || op == "plus" && op2 == "plus" && op3 == "minus" || op == "+" && op2 == "+" && op3 == "minus" || op == "+" && op2 == "plus" && op3 == "-" || op == "plus" && op2 == "+" && op3 == "-" || op == "plus" && op2 == "plus" && op3 == "-" || op == "plus" && op2 == "+" && op3 == "minus" || op == "+" && op2 == "plus" && op3 == "minus")
                {
                    Console.WriteLine(num1 + num2 + num3 - num4);
                    goto rerun;
                }
                else if (op == "plus" && op2 == "plus" && op3 == "times" || op == "plus" && op2 == "+" && op3 == "times" || op == "+" && op2 == "plus" && op3 == "times" || op == "+" && op2 == "+" && op3 == "times" || op == "plus" && op2 == "plus" && op3 == "x" || op == "plus" && op2 == "+" && op3 == "x" || op == "+" && op2 == "plus" && op3 == "x" || op == "+" && op2 == "+" && op3 == "x" || op == "plus" && op2 == "plus" && op3 == "*" || op == "plus" && op2 == "+" && op3 == "*" || op == "+" && op2 == "plus" && op3 == "*" || op == "+" && op2 == "+" && op3 == "*")
                {
                    Console.WriteLine(num1 + num2 + num3 * num4);
                    goto rerun;
                }
                else if (op == "plus" && op2 == "plus" && op3 == "divided by" || op == "+" && op2 == "+" && op3 == "divided by" || op == "plus" && op2 == "+" && op3 == "divided by" || op == "+" && op2 == "plus" && op3 == "divided by" || op == "plus" && op2 == "plus" && op3 == "/" || op == "+" && op2 == "+" && op3 == "/" || op == "plus" && op2 == "+" && op3 == "/" || op == "+" && op2 == "plus" && op3 == "/")
                {
                    Console.WriteLine(num1 + num2 + num3 / num4);
                    goto rerun;
                }
                else if (op == "plus" && op2 == "minus" && op3 == "minus" || op == "+" && op2 == "-" && op3 == "minus" || op == "+" && op2 == "minus" && op3 == "-" || op == "plus" && op2 == "-" && op3 == "-" || op == "plus" && op2 == "minus" && op3 == "-" || op == "plus" && op2 == "-" && op3 == "minus" || op == "+" && op2 == "minus" && op3 == "minus")
                {
                    Console.WriteLine(num1 + num2 - num3 - num4);
                    goto rerun;
                }
                else if (op == "plus" && op2 == "minus" && op3 == "times" || op == "+" && op2 == "-" && op3 == "times" || op == "plus" && op2 == "-" && op3 == "times" || op == "+" && op2 == "minus" && op3 == "times" || op == "plus" && op2 == "minus" && op3 == "x" || op == "+" && op2 == "-" && op3 == "x" || op == "plus" && op2 == "-" && op3 == "x" || op == "+" && op2 == "minus" && op3 == "x" || op == "plus" && op2 == "minus" && op3 == "*" || op == "+" && op2 == "-" && op3 == "*" || op == "plus" && op2 == "-" && op3 == "*" || op == "+" && op2 == "minus" && op3 == "*")
                {
                    Console.WriteLine(num1 + num2 - num3 * num4);
                    goto rerun;
                }
                else if (op == "plus" && op2 == "minus" && op3 == "divided by" || op == "plus" && op2 == "-" && op3 == "divided by" || op == "+" && op2 == "minus" && op3 == "divided by" || op == "+" && op2 == "-" && op3 == "divided by" || op == "plus" && op2 == "minus" && op3 == "/" || op == "plus" && op2 == "-" && op3 == "/" || op == "+" && op2 == "minus" && op3 == "/" || op == "+" && op2 == "-" && op3 == "/")
                {
                    Console.WriteLine(num1 + num2 - num3 / num4);
                    goto rerun;
                }
                else if (op == "+" && op2 == "-" && op3 == "+" || op == "plus" && op2 == "minus" && op3 == "plus" || op == "+" && op2 == "-" && op3 == "plus" || op == "+" && op2 == "minus" && op3 == "+" || op == "plus" && op2 == "-" && op3 == "+" || op == "plus" && op2 == "minus" && op3 == "+" || op == "plus" && op2 == "-" && op3 == "plus" || op == "+" && op2 == "minus" && op3 == "plus")
                {
                    Console.WriteLine(num1 + num2 - num3 + num4);
                    goto rerun;
                }
                else if (op == "+" && op2 == "/" && op3 == "-" || op == "plus" && op2 == "divided by" && op3 == "minus" || op == "+" && op2 == "/" && op3 == "minus" || op == "+" && op2 == "divided by" && op3 == "-" || op == "plus" && op2 == "/" && op3 == "-" || op == "plus" && op2 == "divided by" && op3 == "-" || op == "plus" && op2 == "/" && op3 == "minus" || op == "+" && op2 == "divided by" && op3 == "minus")
                {
                    Console.WriteLine(num1 + num2 / num3 - num4);
                    goto rerun;
                }
                else if (op == "+" && op2 == "/" && op3 == "/" || op == "plus" && op2 == "divided by" && op3 == "divided by" || op == "plus" && op2 == "divided by" && op3 == "/" || op == "plus" && op2 == "/" && op3 == "divided by" || op == "+" && op2 == "divided by" && op3 == "divided by" || op == "plus" && op2 == "divided by" && op3 == "/" || op == "plus" && op2 == "/" && op3 == "divided by" || op == "+" && op2 == "divided by" && op3 == "divided by")
                {
                    Console.WriteLine(num1 + num2 / num3 / num4);
                    goto rerun;
                } else if ( op == "+" && op2 == "/" && op3 == "+" || op == "plus" && op2 == "divided by" && op3 == "plus" || op == "+" && op2 == "/" && op3 == "plus" || op == "+" && op2 == "divided by" && op3 == "+" || op == "plus" && op2 == "/" && op3 == "+" || op == "plus" && op2 == "divided by" && op3 == "+" || op == "plus" && op2 == "/" && op3 == "+" )
                {
                    Console.WriteLine( num1 + num2 / num3 + num4 );
                    goto rerun;
                }



            math2:

                if (op == "plus" && op2 == "plus" || op == "+" && op2 == "+" || op == "plus" && op2 == "+" || op == "+" && op2 == "plus")
                {

                    Console.WriteLine(num1 + num2 + num3);
                    goto rerun;
                }
                else if (op == "/" && op2 == "/" || op == "divided by" && op2 == "divided by" || op == "/" && op2 == "divided by" || op == "divided by" && op2 == "/")
                {

                    Console.WriteLine(num1 / num2 / num3);
                    goto rerun; ;
                }
                else if (op == "-" && op2 == "-" || op == "minus" && op2 == "minus" || op == "-" && op2 == "minus" || op == "minus" && op2 == "-")

                {

                    Console.WriteLine(num1 - num2 - num3);
                    goto rerun;
                }
                else if (op == "x" && op2 == "x" || op == "times" && op2 == "times" || op == "*" && op2 == "*" || op == "x" && op2 == "times" || op == "x" && op2 == "*" || op == "times" && op2 == "x" || op == "times" && op2 == "*" || op == "*" && op == "x" || op == "*" && op2 == "times")

                {

                    Console.WriteLine(num1 * num2 * num3);
                    goto rerun;
                }
                else if (op == "-" && op2 == "+" || op == "minus" && op2 == "+" || op == "minus" && op2 == "plus" || op == "plus" && op2 == "-")
                {

                    Console.WriteLine(num1 - num2 * num3);
                    goto rerun;
                }
                else if (op == "+" && op2 == "-" || op == "plus" && op2 == "minus" || op == "plus" && op2 == "-" || op == "+" && op2 == "minus")
                {

                    Console.WriteLine(num1 + num2 - num3);
                    goto rerun;
                }
                else if (op == "*" && op2 == "divided by" || op == "times" && op2 == "divided by" || op == "x" && op2 == "divided by" || op == "x" && op2 == "/" || op == "times" && op2 == "/" || op == "*" && op2 == "/")
                {

                    Console.WriteLine(num1 * num2 / num3);
                    goto rerun;
                }
                else if (op == "/" && op2 == "-" || op == "divided by" && op2 == "minus" || op == "/" && op2 == "minus" || op == "divided by" && op2 == "-")
                {

                    Console.WriteLine(num1 / num2 - num3);
                    goto rerun;
                }
                else if (op == "/" && op2 == "*" || op == "divided by" && op2 == "times" || op == "/" && op2 == "times" || op == "divided by" && op2 == "*")
                {

                    Console.WriteLine(num1 / num2 * num3);
                    goto rerun;
                }
                else if (op == "/" && op2 == "+" || op == "divided by" && op2 == "plus" || op == "divided by" && op2 == "+" || op == "/" && op2 == "plus")
                {

                    Console.WriteLine(num1 / num2 + num3);
                    goto rerun;
                }
                else if (op == "x" && op2 == "plus" || op == "*" && op2 == "plus" || op == "times" && op2 == "plus" || op == "x" && op2 == "+" || op == "*" && op2 == "+" || op == "times" && op2 == "+")
                {

                    Console.WriteLine(num1 * num2 + num3);
                    goto rerun;
                }
                else if (op == "x" && op2 == "-" || op == "*" && op2 == "-" || op == "times" && op2 == "-" || op == "x" && op2 == "minus" || op == "*" && op2 == "minus" || op == "times" && op2 == "minus")
                {

                    Console.WriteLine(num1 * num2 - num3);
                    goto rerun;
                }
                else if (op == "-" && op2 == "+" || op == "minus" && op2 == "plus" || op == "minus" && op2 == "+" || op == "-" && op2 == "plus")
                {

                    Console.WriteLine(num1 + num2 - num3);
                    goto rerun;
                }
                else if (op == "+" && op2 == "/" || op == "plus" && op2 == "divided by" || op == "plus" && op2 == "/" || op == "+" && op2 == "divided by")
                {

                    Console.WriteLine(num1 + num2 / num3);
                    goto rerun;
                }
                else if (op == "+" && op2 == "x" || op == "+" && op2 == "times" || op == "+" && op2 == "*" || op == "plus" && op2 == "x" || op == "plus" && op2 == "times" || op == "plus" && op2 == "*")
                {

                    Console.WriteLine(num1 + num2 * num3);
                    goto rerun;
                }
                else if (op == "-" && op2 == "x" || op == "-" && op2 == "times" || op == "-" && op2 == "*" || op == "minus" && op2 == "x" || op == "minus" && op2 == "times" || op == "minus" && op2 == "x")
                {

                    goto rerun;
                }
                else
                {
                    Console.WriteLine("Enter a valad Operator next time");
                    goto rerun;
                }




            // does the math

            math:
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
                else if (op == "squared")
                {

                    Console.WriteLine(Math.Pow(num1, 2));
                }
                else if (op == "cubed")
                {
                    Console.WriteLine(Math.Pow(num1, 3));
                }
                else
                {
                    Console.WriteLine("Please Enter a valad op next time");
                }

            // asks if you want to do another problem
            // "idk:" is used for the goto command and makes it so that tou dont have to run the code again if you mess up
            // you can look at alot of the code and see "goto idk;" t4his makes it skip to the loop code
            rerun:
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
                else if (ny == "yes")
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
                    goto start;
                }







            }

        }
    }
}
