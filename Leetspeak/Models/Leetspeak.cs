using System;
using System.Collections.Generic;

namespace Leetspeak
{
  public class LeetspeakTranslator
  {
    public string userInput(string inputString)
    {
      char[] inputCharArray = inputString.ToCharArray();
      List<string> output = new List<string>();
      foreach (char i in inputCharArray)
      {
        output.Add(Translate(i.ToString()));
      }
      string outputString = string.Join("",output.ToArray());
      Console.WriteLine("This is outputString: {0}", outputString);
      //Console.WriteLine("Here is a {0} of using {1} words as {2}", "test", "multiple", "input");
      return outputString;
    }

    public string Translate(string inputString)
    {
        if (inputString == "e")
        {
          return "3";

        } else if (inputString == "o" || inputString == "O")
        {
          return "0";

        } else if (inputString == "I")
        {
          return "1";

        } else if (inputString == "t" || inputString == "T")
        {
          return "7";

        } else if (inputString == "s" || inputString == "S")
        {
          return "Z";
        }
        else
        {
          return inputString;
        }
    }
  }
}
