using System;

namespace TypeApp
{
    class Type
    {
        void Pratice1()
        {
            bool nb = false;
            byte nb1 = 255;
            nb1 += 1;
            Console.WriteLine(nb1);
            nb1 += 1;
            Console.WriteLine(nb1);
        }

        void Pratice2()
        {
            int a = 20;
            object NewObject = a;
            Console.WriteLine("a = {0}, obj = {1}", a, NewObject);
            a = 30;
            Console.WriteLine("a = {0}, obj = {1}", a, NewObject);

            dynamic NewDynamic = a;
            Console.WriteLine("a = {0}, obj = {1}", a, NewDynamic);
            a = 20;
            Console.WriteLine("a = {0}, obj = {1}", a, NewDynamic);
            
        }
        
        static void Main()
        {
            Console.WriteLine("Hello, World");
            Type NewObject = new Type();
            NewObject.Pratice1();
            NewObject.Pratice2();
        }
    }
}