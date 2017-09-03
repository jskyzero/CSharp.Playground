// learn to use class
using System;

namespace RectangleApp
{
    class Rectangle 
    {
        double length;
        double width;
        
        public void Initial()
        {
            length = 1.0;
            width = 0.5;
        }
        public void Display()
        {
            Console.WriteLine("length:{0} width:{1}", length, width);
        }
    }

    class App
    {
        public static void Main()
        {
            Rectangle NewRectangle = new Rectangle();
            NewRectangle.Display();
            NewRectangle.Initial();
            NewRectangle.Display();
        }
    }
}
