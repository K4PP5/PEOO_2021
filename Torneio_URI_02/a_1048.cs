using System;

class MainClass {
  public static void Main (string[] args) {
    double salario = double.Parse(Console.ReadLine());
    double percentual = 0, reajuste = 0, novo = 0;


    if (salario >= 0 && salario <= 400.00) {
      percentual = 15;
      reajuste = (percentual/100) * salario;
      novo = salario + reajuste;
    }

    else if (salario >= 400.01 && salario <= 800.00) {
      percentual = 12;
      reajuste = (percentual/100) * salario;
      novo = salario + reajuste;
    }

    else if (salario >= 800.01 && salario <= 1200.00) {
      percentual = 10;
      reajuste = (percentual/100) * salario;
      novo = salario + reajuste;
    }

    else if (salario >= 1200.01 && salario <= 2000.00) {
      percentual = 7;
      reajuste = (percentual/100) * salario;
      novo = salario + reajuste;
    }

    else {
      percentual = 4;
      reajuste = (percentual/100) * salario;
      novo = salario + reajuste;
    }


    
    Console.WriteLine($"Novo salario: {novo:0.00}\nReajuste ganho: {reajuste:0.00}\nEm percentual: {percentual} %");
  }
}