using System;

class MainClass {
  public static void Main(string[] args) {
    Console.WriteLine("Digite o valor gasto com o combustível em reais:");
    double gastos = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor do litro do combustível em reais:");
    double valor_litro = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a distância percorrida em quilômetros:");
    double distancia = double.Parse(Console.ReadLine());

    double litros = gastos / valor_litro;
    double consumo = distancia / litros;
    double consumokm = gastos / distancia;


    Console.WriteLine($"O consumo médio é de {consumo:0.00} Km por litro\nO gasto por Km percorrido é R$ {consumokm:0.00}");
  }
}