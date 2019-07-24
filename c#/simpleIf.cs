using System;
using System.Collections.Generic;

namespace aSimpleIf
{
  class simpleIf
  {
    public static void Main(string[] args)
    {
      int a = 40;
      // If a is not 30 then the first expression will print, else the 2nd expression will print
      string returnAMsg = !(a == 30) ? $"A is not 30. A is {a}" : "A is 30";
      
      // If b is not less then 20 the first expression will print, else the 2nd expression will print
      int b = 39;
      string guess = !(b < 20) ? $"b is not less than 20 @ b being {b}" : $"Be is less than 20 @ b being {b}";
      
      // If y is not greater than 50 the 2nd expression will print, else the first expression will print
      int y = 50;
      string getR = (y >= 50) ? $"Y is greater than @ {y}" : $"Y is less then @ {y}";
      
      // Writing the data
      Console.WriteLine(returnAMsg);
      Console.WriteLine(guess);
      Console.WriteLine(getr);
    }
  }
}
