using System;

class MainClass {
  public static void Main(string[] args) {
    Console.WriteLine("Digite a operação no formato op1+op2:");
    string[] operacao = Console.ReadLine().Split('+');
    int x = int.Parse(operacao[0]);
    int y = int.Parse(operacao[1]);

    Console.WriteLine($"Soma = {x + y}");
  }
}