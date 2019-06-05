// when use Microsoft (R) Visual C# Compiler version 2.6.0.62309 (d3f6b8e7)
//  csc /langversion:1.0 null.cs
//
// error CS8022: Feature 'nullable types' is not available in C# 1.
// Please use language version 2 or greater.

using System;

namespace NullApp
{
    class Null
    {
        static void GetLine(out int x, out int y)
        {
            Console.WriteLine("First:");
            x = y = Convert.ToInt32(Console.ReadLine());
        }

        static void Main()
        {
            int x, y;
            GetLine(out x, out y);
            int ? a = new int ? ();
            byte ? b = 255;
            b +=1;
            byte c = 1;
            Console.WriteLine("c = {0}", b);
        }
    }
}