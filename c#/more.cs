using System;
using Sysem.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCode
{
  class more
  {
    public static class getName
    {
      public static string NAME { get; set; }
      
      public static getName()
      {
        NAME = Console.ReadLine();
      }
      
      public static sayHi()
      {
        Console.WriteLine($"Hello {NAME}");
      }
    }
    
    public class thisExtends
    {
      string[] names = new string[2];
      
      public string this[int index]
      {
        get { return names[index]; }
        set { names[index] = value; }
      }
    }
    
    public class extended : thisExtends
    {
      names[0] = "Aidan";
      names[1] = "White";
      
      Console.WriteLine($"{names[0]} {names[1]}");
    }
    
    public class readONLY
    {
      private readonly string name;
      
      public readONLY(string NAME_IS)
      {
        this.name = NAME_IS;
      }
      
      public void sayHi()
      {
        Console.WriteLine($"Hello {this.name}");
      }
    }
    public static void Main(string[] args)
    {
      getName();
      getName.sayHi();
      
      extended ex = new extended();
      
      readONLY read = new readONLY(Console.ReadLine());
    }
  }
}
