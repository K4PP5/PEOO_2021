using System; 

class URI {

    static void Main(string[] args) { 
        string[] valores = Console.ReadLine().Split(' ');
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int c = int.Parse(valores[2]);

        int maior = a;
        int medio = b;
        int menor = c;

        if (b > maior) maior = b;
        if (c > maior) maior = c;

        if (b < menor) menor = b;
        if (a < menor) menor = a;
        if (c < menor) menor = c;

        if (c > menor && c < maior) medio = c;
        if (a > menor && a < maior) medio = a;
        if (b > menor && b < maior) medio = b;
        
        
        
        
        

        Console.WriteLine($"{menor}\n{medio}\n{maior}");

        Console.WriteLine("");

        Console.WriteLine($"{a}\n{b}\n{c}");
        
        
    }

}