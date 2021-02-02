using System;

class MainClass {
  public static void Main (string[] args) {
    while (true){
      string[] valores = Console.ReadLine().Split(' ');
      int x1 = int.Parse(valores[0]);
      int y1 = int.Parse(valores[1]);
      int x2 = int.Parse(valores[2]);
      int y2 = int.Parse(valores[3]);

      if (x1 == 0 && y1 == 0 && x2 == 0 && y2 == 0) break;
      else if (x1 == x2 && y1 == y2) Console.WriteLine(0);
      else if (x1 == x2 || y1 == y2 || Math.Abs(y2 - y1) == Math.Abs(x2 - x1)) Console.WriteLine(1);
      else Console.WriteLine(2);
    }
  }
}