using System;
using System.Collections.Genric;

/*
  Sorry if I am tripping you guys. But this is really the best way for
  me to practice what I know. Someday, maybe, I will think of something to make
  with c#. Maybe you guys can give me some ideas? (P.S: Don't make the ideas too hard, please,
  I am overall a starter to c# and really do not know ANY of the frameworks libraries.
*/

namespace someRandomName
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      // Getting name
      Console.Write("Name: ")
      string name = Console.ReadLine();
      
      // Getting age and converting it to 32 bit int
      Console.Write("Age: ");
      int age = Convert.ToInt32(Console.ReadLine());
      
      // Printing some random welcome string
      Console.WriteLine($"{name} is {age} years old");
    }
  }
}
