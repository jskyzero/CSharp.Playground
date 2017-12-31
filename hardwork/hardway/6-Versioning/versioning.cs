// versioning.cs

public class Mybase
{
    public virtual string Meth1()
    {
        return "Mybanse:Meth1";
    }

    public virtual string Meth2()
    {
        return "Mybanse:Meth2";
    }

    public virtual string Meth3()
    {
        return "Mybanse:Meth3";
    }
}

class MyDerived : Mybase
{
    // override the virtual Meth1 using override
    public override string Meth1()
    {
        return "MyDerived:Meth1";
    }

    // Explicityly hide the virtual Meth2 using new
    public new string Meth2()
    {
        return "MyDerived:Meth2";
    }

    // A warning will be issued to alert
    public string Meth3()
    {
        return "MyDerived:Meth3";
    }

    public static void Main()
    {
        MyDerived nMD = new MyDerived();
        Mybase nMB = (Mybase) nMD;

        System.Console.WriteLine(nMB.Meth1());
        System.Console.WriteLine(nMB.Meth2());
        System.Console.WriteLine(nMB.Meth3());
        
        System.Console.WriteLine(nMD.Meth1());
        System.Console.WriteLine(nMD.Meth2());
        System.Console.WriteLine(nMD.Meth3());
    }
}