using System;

class MainClass {
  public static void Main(string[] args) {
    Console.WriteLine("Digite a largura do ambiente em metros:");
    double largura_amb = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o comprimento do ambiente em metros:");
    double comprimento_amb = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a largura do revestimento em centímetros:");
    double largura_rev = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o comprimento do revestimento em centímetros:");
    double comprimento_rev = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o número de peças por caixa:");
    double num_pecas = double.Parse(Console.ReadLine());

    double area = largura_amb * comprimento_amb;
    double revestimento = (largura_rev * comprimento_rev) / 10000;
    double rev_necessario = area / revestimento;
    double caixas = rev_necessario / num_pecas;

    Console.WriteLine($"São necessárias {caixas:0.00} caixas do revestimento.");
  }
}