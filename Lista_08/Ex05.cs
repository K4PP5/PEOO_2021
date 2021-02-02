using System;

class MainClass {
  public static void Main(string[] args) {
    Console.WriteLine("Digite uma frase com três palavras:");
    string[] frase = Console.ReadLine().Split(' ');
    int x = frase[0].Length;
    int y = frase[1].Length;
    int z = frase[2].Length;

    Console.WriteLine($"A senha é {x}{y}{z}");
  }
}