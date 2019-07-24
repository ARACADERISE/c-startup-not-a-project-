using System;
using System.Collection.Generic;

namespace doingTheIf
{
  class IF
  {
    public static void Main(string[] args)
    {
      // This is going to have the ==(equal to) ||(or), &&(and) and the not(!)
      int a = 40;
      if(a == 30) {
        // To make it 40
        a+=10;
      }
      if(a == 30 || !(a == 40)) {
        //Same thing, just declared differently
        a+=10;
      }
      // Only want this to run if it is not greate than 30
      if(!(a > 30)) {
        a+=10;
      }
      if(a == 40 && !(a > 40) && !(a < 40)) {
        Console.WriteLine($"How'd you know {a}");
      }
    }
  }
}
