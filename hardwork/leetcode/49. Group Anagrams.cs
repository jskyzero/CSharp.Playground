using System;
using System.Collections.Generic;
using System.Linq;

public class Solution49 {
  public IList<IList<string>> GroupAnagrams(string[] strs) {
    if (strs.Count() == 0) return new List<IList<string>>();
    Dictionary<string, IList<string>> result = new Dictionary<string, IList<string>>();
    foreach (var str in strs) {
      var sortedStr = String.Concat(str.OrderBy(c => c).ToArray());
      if (result.ContainsKey(sortedStr)) {
        result[sortedStr].Insert(0, str);
      } else {
        result.Add(sortedStr, new List<string> { str });
      }
    }
    return new List<IList<string>>(result.Values);
  }
}