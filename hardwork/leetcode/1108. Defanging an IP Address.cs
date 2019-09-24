using System;
using System.Linq;

public class Solution {
  public string DefangIPaddr(string address) {
    return address.ToArray()
      .Select(s => s.ToString())
      .Select(s => s = s == "." ? "[.]" : s)
      .Aggregate((i, j)=> i + j);
  }
}