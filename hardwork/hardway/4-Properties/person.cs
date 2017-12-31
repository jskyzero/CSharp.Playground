// person.cs

using System;

class Person 
{
    private string myName = "N/A";
    private int myAge = 0;

    // Declare a Name property of type string
    public string Name
    {
        get
        {
            return myName;
        }
        set
        {
            myName = value;
        }
    }

    public int Age 
    {
        get
        {
            return myAge;
        }
        set
        {
            myAge = value;
        }
    }

    public override string ToString()
    {
        return "Name = " + Name + ", Age = " + Age;  
    }

    public static void Main()
    {
        Console.WriteLine("Simple Properties");

        Person newPerson = new Person();
        Console.WriteLine("{0}", newPerson);

        newPerson.Name = "joe";
        newPerson.Age = 99;
        newPerson.Age += 1;
        Console.WriteLine("{0}", newPerson);
    }
}