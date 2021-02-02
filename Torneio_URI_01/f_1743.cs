using System;

class MainClass {
  public static void Main(string[] args) {    
      string[] valores1 = Console.ReadLine().Split(' ');
      string[] valores2 = Console.ReadLine().Split(' ');

      bool x = true;
      int i = 0;
      while (i < 5)
      {
          if (valores1[i]==valores2[i])
          {
              x = false;
              break;
          }
          i++;
      }
      if(x)
      Console.WriteLine("Y");
      else
      Console.WriteLine("N");

  }
}