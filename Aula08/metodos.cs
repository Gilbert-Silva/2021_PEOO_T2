using System;

public class Program {
  public static void Main(string[] args) {
    /*
    int x, y;
    if (args.Length == 0) {
      x = int.Parse(Console.ReadLine());
      y = int.Parse(Console.ReadLine());
    }
    else {
      x = int.Parse(args[0]);
      y = int.Parse(args[1]);
    }
    Console.WriteLine(x + y);
    */
    Console.WriteLine("Digite dois inteiros");
    int m, x, y;
    x = int.Parse(Console.ReadLine());
    y = int.Parse(Console.ReadLine());

    if (x > y) 
      m = x;
    else  
      m = y;
    Console.WriteLine(m);

    m = MaiorValor(x, y);  
    Console.WriteLine(m);

    m = Math.Max(x, y);
    Console.WriteLine(m);

    m = Matematica.MenorValor(x, y);
    Console.WriteLine(m);
  }

  public static int MaiorValor(int a, int b) {
    if (a > b) 
      return a;
    else  
      return b;
  }
}

class Matematica {
  public static int MenorValor(int a, int b) {
    if (a < b) 
      return a;
    else  
      return b;
  }
}

