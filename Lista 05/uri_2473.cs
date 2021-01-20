using System; 

class URI {

    static void Main(string[] args) { 
        string[] jogadas = Console.ReadLine().Split(' ');
        string[] sorteio = Console.ReadLine().Split(' ');
        int contador = 0;

        for (int i = 0; i < 6; i++){
          for (int j = 0; j < 6; j++){
            if (jogadas[i] == sorteio[j]) contador++;
          }
				}

        if (contador == 3) Console.WriteLine("terno");
	      else if (contador == 4) Console.WriteLine("quadra");
	      else if (contador == 5)	Console.WriteLine("quina");
	      else if (contador == 6) Console.WriteLine("sena");
        else Console.WriteLine("azar");

		
    }


}