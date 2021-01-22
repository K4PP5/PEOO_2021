using System;

class MainClass {
  public static void Main(string[] agrs) {

    while (true) {
      string[] valores = Console.ReadLine().Split(' ');
      double distancia = double.Parse(valores[0]);
      double fugitivo = double.Parse(valores[1]);
      double guarda = double.Parse(valores[2]);
      double tempo_fug = distancia / fugitivo;
      double tempo_guard = distancia / guarda;

      if (tempo_guard < tempo_fug) Console.WriteLine('S');
      else Console.WriteLine('N');


    }
    
  }
}