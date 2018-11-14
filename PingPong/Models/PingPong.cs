using System;
using System.Collections.Generic;

namespace Game{

// Backend, functionality
  public class PingPong
  {
    public static string IsPingPong(int number)
    { 
        if (number % 3 == 0 && number % 5 ==0)
        {
            return "ping pong";
        } else if (number % 3 == 0) 
        {
            return "ping";
        }
        else if (number % 5 == 0) 
        { 
            return "pong";
        }
        else
         {
            return number.ToString();
        }
    } 

// Front end
    public static void Main()
    {
        
        Console.WriteLine("Give me a Number");
        int numberTest = int.Parse(Console.ReadLine());
        for (int i=1; i <= numberTest; i++)
      {
         Console.WriteLine(IsPingPong(i));
      } 
      } 
  }
}