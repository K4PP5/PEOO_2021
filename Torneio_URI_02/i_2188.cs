using System;

class MainClass {
  public static void Main (string[] args) {
    int contador = 0;
    while (true){
      int regioes = int.Parse(Console.ReadLine());
      if (regioes == 0) break;

      int A = -10000, B = -10000, C = 10000, D = 10000;

      for (int i = 1; i <= regioes; i++) {
        string[] valores = Console.ReadLine().Split(' ');
        int x = int.Parse(valores[0]);
        int y = int.Parse(valores[1]);
        int u = int.Parse(valores[2]);
        int v = int.Parse(valores[3]);

        if (x > A) A = x;
        if (y < C) C = y;
        if (u < D) D = u;
        if (v > B) B = v;
      }
      contador++;

      Console.WriteLine($"Teste {contador}");
      if (A < D && B < C) Console.WriteLine($"{A} {C} {D} {B}\n");
      else Console.WriteLine("nenhum\n");

    }
  }
}