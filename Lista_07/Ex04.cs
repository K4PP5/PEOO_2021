using System;

class MainClass {
  public static int MMC(int x, int y) {
    int a = x;
    int b = y;
    
    while (y != 0) {
       int r = x % y;
       x = y;
       y = r;
    }
    return (a*b/x);
  }

  public static void Main(string[] args) {
    Console.WriteLine("Informe os dois valores:");
    string[] valores = Console.ReadLine().Split();
    int valor1 = int.Parse(valores[0]);
    int valor2 = int.Parse(valores[1]);

    int mmc = MMC(valor1, valor2);

    Console.WriteLine($"MMC: {mmc}");
    
  }
}