using System;
using System.Collections.Generic;

namespace doingTheSwitch
{
  class Switch
  {
    public static void Main(string[] args) 
    {
      int a = 10;
      while(a < 25){
       switch(a){
         case 5:
           Console.WriteLine($"a is @ {a}");
           while(a < 100) {
             Console.WriteLine(a);
             a+=2;
           }
           break;
         case 10:
           Console.WriteLine($"a is @ {a}");
           while(a < 150) {
             Console.WriteLine(a);
             a+=4;
           }
           break;
         default:
           Console.WriteLine($"a is @ {a}");
           while(a < 200) {
             Console.WriteLine(a);
             a+=8;
           }
           break;
       }
      }
    }
  }
}
