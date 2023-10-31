
using System.IO;
using System;

class Program
{
    static void Main()
    {
        
Console.Write("Enter num1: ");
double num1 = Convert.ToDouble(Console.ReadLine());
      if ( num1 < 0 ){
          Console.WriteLine("Cannot Compute negative numbers");
          return;
      }

Console.Write("Enter operator: ");
string op = Console.ReadLine();

Console.Write("Enter num2: ");
double num2 = Convert.ToDouble(Console.ReadLine());
       if ( num2 < 0 ){
          Console.WriteLine("Cannot Compute negative numbers"); 
          return;
      }

if (op == "+"){
     Console.WriteLine(num1 + num2);
} else if (op == "-"){
     Console.WriteLine(num1 - num2);
} else if (op == "/"){
     Console.WriteLine(num1 / num2);
} else if (op == "*"){
     Console.WriteLine(num1 * num2);
} else {
     Console.WriteLine("Invalid Operator");
}

    }
}
