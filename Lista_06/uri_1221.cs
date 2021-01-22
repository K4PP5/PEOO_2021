using System;

class MainClass {
  public static void Main(string[] agrs) {
    int repeticoes = int.Parse(Console.ReadLine());

    for (int i = 1; i <= repeticoes; i++) {
      long numero = long.Parse(Console.ReadLine());
      int contador = 0;

      for (long k = 2; k < numero; k++) {
        if (numero % k == 0) {
          contador = 1;
          Console.WriteLine($"{numero} % {k} = {numero % k}");
        }
      }

      if (contador == 0) Console.WriteLine("Prime");
      else Console.WriteLine("Not Prime");

      

    }
  }
}