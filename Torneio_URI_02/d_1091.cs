using System;

class MainClass {
  public static void Main (string[] args) {
    while (true){
      int consultas = int.Parse(Console.ReadLine());
      if (consultas == 0) break;
      string[] valores = Console.ReadLine().Split(' ');
      int xPV = int.Parse(valores[0]);
      int yPV = int.Parse(valores[1]);

     

      for (int i = 0; i < consultas; i++) {
        string[] valores2 = Console.ReadLine().Split(' ');
        int xres = int.Parse(valores2[0]);
        int yres = int.Parse(valores2[1]);

        if (xres == xPV || yres == yPV) Console.WriteLine("divisa");
        else if (xres > xPV && yres > yPV) Console.WriteLine("NE");
        else if (xres < xPV && yres < yPV) Console.WriteLine("SO");
        else if (xres < xPV && yres > yPV) Console.WriteLine("NO");
        else if (xres > xPV && yres < yPV) Console.WriteLine("SE");
      }
    }
  }
}