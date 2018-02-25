using System;
using System.Type;

namespace class_2 {
  class Program {
    // static int SumEvens(int[] numbersList) {
    //   int total = 0;
    //   foreach (var number in numbersList) {
    //     if (number % 2 == 0) total += number;
    //   }
    //   return total;
    // };

    static void Main (string[] args) {
      int[] test = {1, 2, 3};
      foreach(int num in test) {
        Console.WriteLine(num);
        Console.WriteLine(typeOf(test));
      }
    }
  }
}