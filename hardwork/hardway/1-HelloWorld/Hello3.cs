// Hello3.cs
// arguments: any content you entered

using System;

public class Hello3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World1");
        Console.WriteLine("You enteres {0}", args.Length);
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("No.{0}:{1}", i, args[i]);
        }
    }
}