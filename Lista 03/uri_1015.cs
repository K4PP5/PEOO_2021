using System;

class MainClass {
  public static void Main (string[] args) {
    string[] values1 = Console.ReadLine().Split(' ');
    string[] values2 = Console.ReadLine().Split(' ');
    float x1 = float.Parse(values1[0]);
    float y1 = float.Parse(values1[1]);
    float x2 = float.Parse(values2[0]);
    float y2 = float.Parse(values2[1]);

    double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));

    Console.WriteLine($"{distance:0.0000}");
  }
}