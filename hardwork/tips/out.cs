// out 关键字通过引用传递参数。
// 它与 ref 关键字相似，只不过 ref 要求在传递之前初始化变量。
// 它也类似于 in 关键字，只不过 in 不允许通过调用方法来修改参数值。

using System;
using static System.Console;

public class Out {

  public static void ChangeValue(out int value) {
    value = 520;
  }

  public static void Main(string[] args) {

    ChangeValue(out int num);
    WriteLine($"Hello World {num} times");
  }
}