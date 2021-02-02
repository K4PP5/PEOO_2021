using System;

class MainClass{
  public static void Main(string[] args){
    double tempo = double.Parse(Console.ReadLine());
    double velocidade = double.Parse(Console.ReadLine());
    double distancia = velocidade * tempo;
    double litros = distancia / 12;

    Console.WriteLine($"{litros:0.000}");
  }
}