// Calling methods from a DLL file
using System;
using MyDLL;

class MyClient
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calling methods from MyDLL.DLL");
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: MyClient <num1> <num2>");
            return ;
        }
        long num1 = long.Parse(args[0]);
        long num2 = long.Parse(args[1]);
        long sum = AddClass.Add(ref num1, ref num2);
        long product = MultiplyClass.Multiply(num1, num2);
        Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
        Console.WriteLine("{0} * {1} = {2}", num1, num2, product);
    }
}