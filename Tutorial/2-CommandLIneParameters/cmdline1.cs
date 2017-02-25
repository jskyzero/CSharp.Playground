// cmdline1.cs

using System;

public class CommandLine
{
    public static int Main(string[] args)
    {
        // Length is Read-Only
        Console.WriteLine("Nubers:{0}", args.Length);
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("No{0}:{1}", i, args[i]);
        }
        return args.Length;
    }
}