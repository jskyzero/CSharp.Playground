// interface.cs

using System;

public interface MyInterface 
{
    // Property
    string Name 
    {
        get;
        set;
    }
    int Counter
    {
        get;
    }
}

public class Emploee : MyInterface
{
    public static int TotalNumbers;
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public int Counter
    {
        get
        {
            return TotalNumbers;
        }
    }
    public Emploee()
    {
        TotalNumbers = ++TotalNumbers;
    }
}

public class MainClass
{
    public static void Main()
    {
        Console.Write("Enter a name");
        string name = Console.ReadLine();
        Emploee NewEmploee = new Emploee();
        NewEmploee.Name = name;
        Console.WriteLine("Name = {0}, Total Number = {1}", NewEmploee.Name.ToString(), NewEmploee.Counter.ToString());
    }
}