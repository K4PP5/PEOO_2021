using System;

class MainClass {
  public static void Main(string[] args) {
    int numero = int.Parse(Console.ReadLine());
    double qtd_horas = int.Parse(Console.ReadLine());
    double sal_hora = double.Parse(Console.ReadLine());

    Console.WriteLine($"NUMBER = {numero}\nSALARY = {sal_hora*qtd_horas:0.00}");
  }
}