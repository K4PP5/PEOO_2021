using System;

class MainClass {
  public static void Main (string[] args) {
    int distance = int.Parse(Console.ReadLine());
    double fuel = double.Parse(Console.ReadLine());
    double consumption = distance / fuel;

    Console.WriteLine($"{consumption:0.000} km/l");
  }
}