using System;

class MainClass {
  public static void Main (string[] args) {
    int valor1 = int.Parse(Console.ReadLine());
    int valor2 = int.Parse(Console.ReadLine());
    
    int maior = valor1, menor = valor2, soma = 0;
    if (valor2 > maior) {
      maior = valor2;
      menor = valor1;
    }
    

    for (int i = menor; i <= maior; i++) {
      if (i % 13 != 0) soma += i;

    }
    Console.WriteLine(soma);
  }
}