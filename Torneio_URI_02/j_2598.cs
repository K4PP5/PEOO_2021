using System;

class MainClass {
  public static void Main (string[] args) {
    double qtd = double.Parse(Console.ReadLine());
    
    for (double i = 0; i < qtd; i++) {
      string[] valores = Console.ReadLine().Split(' ');
      double A = double.Parse(valores[0]);
      double B = double.Parse(valores[1]);

      Console.WriteLine(Math.Ceiling(A/B));
      Console.WriteLine(A%B);
    }
  }
}