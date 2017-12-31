// tokens.cs
using System;
// The System.Collections namespcae is make availasble
using System.Collections;

// Declare the Tokens class:
public class Tokens : IEnumerable
{
    private string[] elements;

    Tokens(string sourse, char[] delimiters)
    {
        // Parse the string into tokens:
        elements = sourse.Split(delimiters);
    }

     // IEnumerable interface Implementation:
     // Declaration of the GetEnumerator() methon
     // require by IEnumerable

     public IEnumerator GetEnumerator()
     {
         return new TokenEnumerator(this);
     }

     // Inner class implements IEnumerable interface:
     private class TokenEnumerator : IEnumerator
     {
         private int position = -1;
         private Tokens t;

         public TokenEnumerator(Tokens t)
         {
             this.t = t;
         }
         
         // Declare the MoveNext method require bu IEnumerable:
         public bool MoveNext()
         {
             if (position < t.elements.Length - 1)
             {
                 position++;
                 return true;
             } else {
                 return false;
             }
         }

        // Declare the Reset method required by IEnumerator:
         public void Reset()
         {
            position = -1;
         }
         
         // Declare the Current property required by IEnumerable:
         public object Current
         {
             get 
             {
                 return t.elements[position];
             }
         }
     }

     // Test Tokens, TokenEnumerator

     static void Main()
     {
         // Testing Tokens by breaking the string into tokens:
         Tokens f = new Tokens("This is a well-done program.", new char[]{' ', '-'});
         foreach (string item in f)
         {
             Console.WriteLine(item);
         }
     }
}