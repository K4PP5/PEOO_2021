using System;

class MainClass {
  public static void Main(string[] args) {
    int valor = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 10; i++) {
      Console.WriteLine($"{i} x {valor} = {i*valor}");
    }
  }
}