using System;
using System.Collection.Generic;

namespace somethingToDoWithADoWhile
{
  class doWhile
  {
    public static void Main(string[] args)
    {
      int a = 50;
      do {
        Console.WriteLine(a);
        a+=10;
      } while(a < 500);
    }
  }
}
