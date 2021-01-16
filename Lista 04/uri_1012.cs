using System;

class MainClass{

  public static void Main(string[] args){
    string[] values = Console.ReadLine().Split(' ');
    double A = double.Parse(values[0]);
    double B = double.Parse(values[1]);
    double C = double.Parse(values[2]);

    double triangulo = TriangleArea(A, C);
    double circulo = CircleArea(C);
    double trapezio = TrapeziumArea(A, B, C);
    double quadrado = SquareArea(B);
    double retangulo = RectangleArea(A, B);

    Console.WriteLine($"TRIANGULO: {triangulo:0.000}\nCIRCULO: {circulo:0.000}\nTRAPEZIO: {trapezio:0.000}\nQUADRADO: {quadrado:0.000}\nRETANGULO: {retangulo:0.000}");


  }

  static double TriangleArea(double b, double h){
    double area = (b * h) / 2;
    return area;
  }
  static double CircleArea(double r){
    double area = 3.14159 * Math.Pow(r, 2);
    return area;
  }
  static double TrapeziumArea(double B, double b, double h){
    double area = (B+b) * h / 2;
    return area;
  }
  static double SquareArea(double b){
    double area = b * b;
    return area;
  }
  static double RectangleArea(double b, double h){
    double area = b * h;
    return area;
  }
}