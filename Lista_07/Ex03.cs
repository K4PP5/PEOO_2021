using System;

class MainClass {
  public static void Intervalo(double x, out int inicio, out int fim) {
    inicio = (int)Math.Floor(x);
    fim = (int)Math.Ceiling(x);
  }

  public static void Main(string[] args) {
    Console.WriteLine("Informe o número:");
    double numero = double.Parse(Console.ReadLine());
    int inicio, fim;

    Intervalo(numero, out inicio, out fim);

    Console.WriteLine($"Intervalo: [{inicio},{fim}]");
  }
}