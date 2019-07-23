using System;
using System.Collections.Genric;

// This is me just practicing what i've learned
/*
If you're interested then please, be my guest and read my newby ass c# code!
If you're not then why the hell did you even click on the project the clearly states "not a project"
Lol, I'm just messing with you. Enjoy reading my newby ass code
*/

namespace IWantToGetData
{
  class anotherUselessClassThatDoesNotFollowTheFileName
  {
    public static void Main(string[] args)
    {
      // I am now going to attemp to make a line of c# that gets data from user input and converts it to a int
      int age = /* I think that Convert.ToInt32() returns a int of 32 bits. Please correct me if I am wrong*/ Convert.ToInt32(Console.ReadLine());
      // Now i was to use the ++ and --
      
      // This will add to b and a
      int b = 14; // 15
      int a = ++b; // 15
      // This will add to y, but not to r
      int r = 14; // 15
      int y = r++; // 14
      
      // var just means I can assign the variable name any datatype, but once that datatype has been detected it won't be able
      // to change
      var myRandomVar = "A STRING";
      // Const just keeps the data type constant(or another words permanent, unchangable)
      const myName = "GetStuffDone";
      // A float is larger than a int but lower than a double
      float lowYetHigh = 14.8;
      // A double is larger than both a float and int
      double highHigh = 478.8903;
      // A string is well..IF YOU'RE HERE YOU SHOULD KNOW..
      string name = "A string, for you newby programmers, is a line of characters as one";
      // A char is just one letter, example what my name starts with
      char myNameStartsWith = "G";
    }
  }
}
