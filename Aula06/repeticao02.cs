using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite um valor inteiro");
    int x = int.Parse(Console.ReadLine());

    int n = 0;
    while (n <= x) {
      Console.WriteLine(n);
      n = n + 2; // n += 2;
    }
    Console.WriteLine($"Fim {n}");
    
    for (n = 0; n <= x; n = n + 2) {
      Console.WriteLine(n);
    }
    Console.WriteLine($"Fim {n}");

    n = 0;
    do {
      Console.WriteLine(n);
      n = n + 2; // n += 2;
    } while (n <= x);
    Console.WriteLine($"Fim {n}");

    string s = "Programação em C#";
    foreach(char c in s)
      Console.WriteLine(c);
  }
}