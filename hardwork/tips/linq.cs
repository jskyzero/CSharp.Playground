using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(0, 100)
                      .Select(i => (new Random(i)).Next())
                      .Where(x => x > 0 && x % 2 == 0)
                      .Select(x => x % 10)
                      .OrderBy(x => x)
                      .ToList()
                      .ForEach(new Action<int>(x => {
                          Console.Write(x.ToString() + " ");
                      }));
        }
    }
}
