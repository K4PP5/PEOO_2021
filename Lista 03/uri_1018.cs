using System;

class MainClass {
  public static void Main (string[] args) {
    int value = int.Parse(Console.ReadLine());
    int i = 100;
    Console.WriteLine(value);

    while (i != 0){
      int y = value / i;
      int x = y * i;
      Console.WriteLine($"{y} nota(s) de R$ {i:0.00}");
      value -= x;

      if (i == 100) i = 50;
      else if (i == 50) i = 20;
      else if (i == 20) i = 10;
      else if (i == 10) i = 5;
      else if (i == 5) i = 2;
      else if (i == 2) i = 1;
      else i = 0;
    }

  }
}