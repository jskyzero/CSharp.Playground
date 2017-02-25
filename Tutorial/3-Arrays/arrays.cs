// arrays.cs

using System;

public class Arrays 
{
    public static void Main()
    {
        int [] numbers;
        numbers = new int[10];
        numbers = new int[20];

        string[] names0 = new string[2]{"huang", "zhang"};
        
        string[,] names = new string[2,2]{{"1","2"}, {"1", "2"}};

        byte[][] scores = new byte[5][];

        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = new byte[i+3];
        }

        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("Length of {0} is {1}", i, scores[i].Length);
        }

    }
}