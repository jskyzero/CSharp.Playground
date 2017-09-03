// cmdline2.cs
using System;

public class CommandLine
{
    public static void Main(string[] args)
    {
        foreach(string str in args)
        {
            Console.WriteLine(str);
        }
    }
}