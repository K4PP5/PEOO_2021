using System;

class MainClass {
  public static void Main(string[] args) {    

    while (true) {
      string[] valores = Console.ReadLine().Split(' ');
      int h1 = int.Parse(valores[0]);
      int m1 = int.Parse(valores[1]);
      int h2 = int.Parse(valores[2]);
      int m2 = int.Parse(valores[3]);

      if (h1 == 0 && m1 == 0 && h2 == 0 && m2 == 0) break;
      if (h2 < h1) h2 = h2 + 24;
      if (h2 == h1 && m2 < m1){
        h2 = h2 + 24;
      }


      int total1 = (h1 * 60) + m1;
      int total2 = (h2 * 60) + m2;

      Console.WriteLine(total2-total1);

    }
  }
}