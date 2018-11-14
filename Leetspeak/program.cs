using  System;
using System.Collections.Generic;

namespace  Leetspeak
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter the string");
      string userInputString = Console.ReadLine();

      LeetspeakTranslator newLeetspeak = new LeetspeakTranslator();

      Console.WriteLine(newLeetspeak.userInput(userInputString));
    
    }
  }
}
