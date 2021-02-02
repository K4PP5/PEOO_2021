using System;

class MainClass {
  public static void Main (string[] args) {
      int testes = int.Parse(Console.ReadLine());

      for (double i = 1; i <= testes; i++) {
        string[] valores = Console.ReadLine().Split(' ');
        int pa = int.Parse(valores[0]);
        int pb = int.Parse(valores[1]);
        double cresA = (double.Parse(valores[2])) / 100.00;
        double cresB = (double.Parse(valores[3])) / 100.00;

        int contagem_anos = 0;

        while (pa <= pb && contagem_anos <= 100) {
          pa += (int) Math.Floor(pa*cresA);
          pb += (int) Math.Floor(pb*cresB);

          contagem_anos++;
        }

        if (contagem_anos <= 100) Console.WriteLine($"{contagem_anos} anos.");
        else Console.WriteLine("Mais de 1 seculo.");
      }

  }
}