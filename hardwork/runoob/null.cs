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