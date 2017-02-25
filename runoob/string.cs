using System;

namespace StringApp
{
    class StringPractice
    {
        static void Practice1()
        {
            string str1 = "huang";
            string str2 = "jin";
            Console.WriteLine((str1 + str2).Replace("j", "jj"));
        }

        static void Main()
        {
            Practice1();
        }
    }
}