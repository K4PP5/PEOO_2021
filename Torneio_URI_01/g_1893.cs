using System;

class MainClass {
  public static void Main(string[] args) {
    string[] valores = Console.ReadLine().Split(' ');
    int A = int.Parse(valores[0]);
    int B = int.Parse(valores[1]);

    if (B >= 97 && B <= 100) Console.WriteLine("cheia");
    else if (B < A && B < 97 && B >= 3) Console.WriteLine("minguante");
    else if (B > A && B <= 96 && B >= 3) Console.WriteLine("crescente");
    else if (B <= 2 && B >= 0) Console.WriteLine("nova");
  }
}