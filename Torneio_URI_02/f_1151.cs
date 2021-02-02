using System;

class MainClass {
  public static void Main (string[] args) {
    int valor = int.Parse(Console.ReadLine());
    
    int proximo = 0, anterior = 0, atual = 1;
    for (int i = 1; i <= valor; i++) {
      if (i == valor) Console.WriteLine(anterior);
      else Console.Write(anterior + " ");
      proximo = anterior + atual;
      anterior = atual;
      atual = proximo;
    }
    
  }
}