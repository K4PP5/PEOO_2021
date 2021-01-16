using System;

class MainClass {
  public static void Main (string[] args) {
    string[] values = Console.ReadLine().Split(' ');
    int value0 = int.Parse(values[0]);
    int value1 = int.Parse(values[1]);
    int value2 = int.Parse(values[2]);

    int highest = value0;
    if (value1 > highest) highest = value1;
    if (value2 > highest) highest = value2;

    Console.WriteLine($"{highest} eh o maior");


  }
}