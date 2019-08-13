using System;
using System.Runtime.InteropServices;

namespace console
{
    class Program
    {

        [DllImport("lib/cppclasslib.dll", EntryPoint="PrintStr2", CharSet=CharSet.Unicode, CallingConvention=CallingConvention.Cdecl)]
        static extern void PrintStr2();

        static void Main(string[] args)
        {
            var str1 = classlib.Values.strValue;
            Console.Write(String.Format("{0} ", str1));
            PrintStr2();
        }
    }
}
