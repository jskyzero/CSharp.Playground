using System;
using System.Collections.Generic;
using System.Linq;

public class Solution68 {
  public IList<string> FullJustify(string[] words, int maxWidth) {
    IList<string> result = new List<string>();
    IList<string> lineWords = new List<string>();
    int lineWordsLength = 0;

    foreach (var word in words) {
      if (lineWordsLength + word.Length > maxWidth) {
        char[] newLine = Enumerable.Range(0, maxWidth).Select(i => ' ').ToArray();
        int extraSpace, extraRemainder;

        if (lineWords.Count - 1 == 0) {
          extraSpace = maxWidth - lineWordsLength;
          extraRemainder = 0;
        } else {
          extraSpace = (maxWidth - lineWordsLength + lineWords.Count) / (lineWords.Count - 1);
          extraRemainder = (maxWidth - lineWordsLength + lineWords.Count) % (lineWords.Count - 1);
        }

        int beginIndex = 0;

        foreach (var lineWord in lineWords) {
          lineWord.CopyTo(0, newLine, beginIndex, lineWord.Length);

          if (extraRemainder > 0) {
            extraRemainder -= 1;
            beginIndex += 1;
          }
          beginIndex += (lineWord.Length + extraSpace);
        }
        result.Add(new string(newLine));

        lineWords.Clear();
        lineWordsLength = 0;
      }

      lineWords.Add(word);
      lineWordsLength += (word.Length + 1);
    }

    char[] lastLine = Enumerable.Range(0, maxWidth).Select(i => ' ').ToArray();
    string lastLinePart = String.Join(" ", lineWords);
    lastLinePart.CopyTo(0, lastLine, 0, lastLinePart.Length);
    result.Add(new string(lastLine));
    return result;
  }
}