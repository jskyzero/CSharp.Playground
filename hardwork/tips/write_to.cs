using System;
using System.IO;
using System.Text;


class WriteTo {
  public static void Main(string[] args) {
    using (var file = File.Open("test.exe", FileMode.Create)) {
    // using (var file = File.OpenWrite("test.exe")) {
      var bytes = UTF8Encoding.UTF8.GetBytes("123");
      file.Write(bytes, 0, bytes.Length);
    }
  }
}