using System;

class MainClass {
  public static void Main(string[] args) {
    string[] valores = Console.ReadLine().Split(' ');
    int A = int.Parse(valores[0]);
    int B = int.Parse(valores[1]);

    switch (A) {
      case 1: Console.WriteLine($"Total: R$ {4.00 * B:0.00}"); break;
      case 2: Console.WriteLine($"Total: R$ {4.50 * B:0.00}"); break;
      case 3: Console.WriteLine($"Total: R$ {5.00 * B:0.00}"); break;
      case 4: Console.WriteLine($"Total: R$ {2.00 * B:0.00}"); break;
      case 5: Console.WriteLine($"Total: R$ {1.50 * B:0.00}"); break;
    }
  }
}