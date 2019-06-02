using System;
using System.Collections.Generic;
using System.Linq;

class ListErase {
  class A {
    public int A1 = 0;
    public int A2 = 0;
  }

  public static void Main(string[] args) {
    var list = new List<A> {
      new A { A1 = 1, A2 = 1 },
      new A { A1 = 2, A2 = 2 },
      new A { A1 = 3, A2 = 3 },
    };

    Action<List<A>> printList = new Action<List<A>>(l => {
      Console.Out.WriteLine(String.Join("\n", l.Select(a => string.Format("A1: {0}\nA2: {1}", a.A1, a.A2))));
    });

    Console.Out.WriteLine("Initial");
    printList.Invoke(list);

    list.Remove(list.Where(a => a.A1 == 2).FirstOrDefault());
    Console.Out.WriteLine("Remove a.A1 == 2");
    printList.Invoke(list);


  }
}