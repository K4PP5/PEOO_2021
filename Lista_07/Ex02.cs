using System;

class MainClass {
  public static void Ordenar(ref int x, ref int y, ref int z) {
    int maior = x, medio = y, menor = z;
    if (y > maior) maior = y;
    if (z > maior) maior = z;

    if (x < menor) menor = x;
    if (y < menor) menor = y;

    if (x > menor && x < maior) medio = x;
    if (z > menor && z < maior) medio = z;

    x = maior;
    y = medio;
    z = menor;
  }


  public static void Main(string[] args) {
    Console.WriteLine("Informe os três valores:");
    string[] valores = Console.ReadLine().Split();
    int valor1 = int.Parse(valores[0]);
    int valor2 = int.Parse(valores[1]);
    int valor3 = int.Parse(valores[2]);

    Ordenar(ref valor1, ref valor2, ref valor3);
    Console.WriteLine($"Maior: {valor1}\nMédio: {valor2}\nMenor: {valor3}");
    
  }
}