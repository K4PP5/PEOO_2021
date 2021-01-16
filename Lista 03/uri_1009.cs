using System;

class MainClass {
  public static void Main(string[] args) {
    string name = Console.ReadLine();
    double fixed_salary = double.Parse(Console.ReadLine());
    double total_sales = double.Parse(Console.ReadLine());
    double total_salary = fixed_salary + (0.15 * total_sales);

    Console.WriteLine($"TOTAL = R$ {total_salary:0.00}");
  }
}