// struct2.cs
using System;

class MyClass
{
    public int x;
}

struct MyStruct
{
    private int data;
    public int x
    {
        get
        {
            return data;
        }
        set
        {
            if (value < 100)
                data = value;
        }
    }
}

class TextClass
{
    public static void Change(MyClass tMC)
    {
        tMC.x = 1;
    }
    public static void Change(MyStruct tMS)
    {
        tMS.x = 1;
    }

    static void Main()
    {
        MyStruct tMS = new MyStruct();
        MyClass tMC = new MyClass();
        tMS.x = 5;
        tMC.x = 5;
        Change(tMS);
        Change(tMC);
        Console.WriteLine("tMS.x = {0}", tMS.x);
        Console.WriteLine("tMC.x = {0}", tMC.x);
    }
}