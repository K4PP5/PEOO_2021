using System;

class MainClass {
  public static void Main(string[] args) {
    Console.WriteLine("Digite três valores separados por vírgulas:");
    string[] operacao = Console.ReadLine().Split(',');
    int x = int.Parse(operacao[0]);
    int y = int.Parse(operacao[1]);
    int z = int.Parse(operacao[2]);

    Console.WriteLine($"O produto entre os valores é {x*y*z}");
  }
}