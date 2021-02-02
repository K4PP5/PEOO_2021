using System;

class MainClass {
  public static void Main(string[] args) {
    Console.WriteLine("Digite o nome do estado:");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite o número de habitantes:");
    double habitantes = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a área do estado em Km²:");
    double area = double.Parse(Console.ReadLine());

    Console.WriteLine($"A densidade demográfica do {nome} é de {habitantes/area:0.00} hab/Km2");
  }
}