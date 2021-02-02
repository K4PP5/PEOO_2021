using System;

class MainClass {
  public static void Main(string[] args) {
    string[] valores = Console.ReadLine().Split(' ');
    int A = int.Parse(valores[0]);
    int B = int.Parse(valores[1]);
    int C = int.Parse(valores[2]);

    if (A + B == C || B + C == A || A + C == B) Console.WriteLine("S");
    else if (A == B || B == C || C == A || A == C) Console.WriteLine("S");
    else Console.WriteLine("N");
  }
}