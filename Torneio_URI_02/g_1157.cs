using System;

class MainClass {
  public static void Main (string[] args) {
    int valor = int.Parse(Console.ReadLine());
    
    for (int i = 1; i < valor; i++) {
      if (valor % i == 0) Console.WriteLine(i);
    }
    

  }
}