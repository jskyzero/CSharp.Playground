using System;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime NowTime = DateTime.Now;
            Console.WriteLine(NowTime.ToString("yy/MM/dd HH:MM"));
            Console.WriteLine("Hello World!");
            TodoUI UI = new TodoUI();
            UI.MainFunc();
        }
    }
}
