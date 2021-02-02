using System;

class MainClass {
  public static void Main(string[] agrs) {
    string[] dia_inicio = Console.ReadLine().Split(' ');
    int dia_i = int.Parse(dia_inicio[1]);

    string[] tempo_inicio = Console.ReadLine().Split(':');
    int hora_i = int.Parse(tempo_inicio[0]);
    int min_i = int.Parse(tempo_inicio[1]);
    int seg_i = int.Parse(tempo_inicio[2]);

    string[] dia_final = Console.ReadLine().Split(' ');
    int dia_f = int.Parse(dia_final[1]);

    string[] tempo_final = Console.ReadLine().Split(':');
    int hora_f = int.Parse(tempo_final[0]);
    int min_f = int.Parse(tempo_final[1]);
    int seg_f = int.Parse(tempo_final[2]);

    int t_i = dia_i * 86400 + hora_i * 3600 + min_i * 60 + seg_i;
    int t_f = dia_f * 86400 + hora_f * 3600 + min_f * 60 + seg_f;

    int dif = t_f - t_i;

    int cont_d = dif / 86400;
    dif %= 86400;

    int cont_h = dif / 3600;
    dif %= 3600;

    int cont_m = dif / 60;
    dif %= 60;

    int cont_s = dif; 

    Console.WriteLine($"{cont_d} dia(s)\n{cont_h} hora(s)\n{cont_m} minuto(s)\n{cont_s} segundo(s)");

    


  }
}