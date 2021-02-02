using System;

class MainClass {
  public static double Maior(double x, double y) {
    double maior = x;
    if (y > x) maior = y;

    return maior;
  }

  public static void Main(string[] args) {
    Console.WriteLine("Informe os dois valores:");
    string[] valores = Console.ReadLine().Split();
    double valor1 = double.Parse(valores[0]);
    double valor2 = double.Parse(valores[1]);

    double maior = Maior(valor1, valor2);
    Console.WriteLine($"Maior: {maior}");


  }
}