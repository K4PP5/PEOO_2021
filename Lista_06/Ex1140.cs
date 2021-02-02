using System;

class MainClass {
  public static void Main(string[] agrs) {
    while (true){
      string[] frase = Console.ReadLine().Split(' ');
      if (frase[0] == "*") break;
      int contador = 0;

      Console.WriteLine(frase.Length);

      for (int i = 0; i < (frase.Length - 1); i++) {
        string palavra1 = (frase[i]).ToLower();
        string palavra2 = (frase[i + 1]).ToLower();

        if (palavra1[0] != palavra2[0]) {
          Console.WriteLine('N');
          contador = 1;
          break;
        }
      }

      if (contador == 0) Console.WriteLine('Y');
    }
    
  }
}