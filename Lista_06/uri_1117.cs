using System;

class MainClass {
  public static void Main(string[] agrs) {

    double media = 0;
    int contador = 0;

    while (true) {
      if (contador == 2) break;
      double nota = double.Parse(Console.ReadLine());

      if (!(nota >= 0 && nota <= 10)) Console.WriteLine("nota invalida");
      else {
        media += nota;
        contador++;
      }
    }
    media /= 2;
    Console.WriteLine($"media = {media:0.00}");
  }
}