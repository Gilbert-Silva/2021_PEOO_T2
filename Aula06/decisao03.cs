using System;

public class Program {
  public static void Main() {
    bool x;
    Boolean y;
    Console.WriteLine("Digite o DDD da cidade");
    int m = int.Parse(Console.ReadLine());

    if (m == 84) Console.WriteLine("Natal");
    else
      if (m == 83) Console.WriteLine("João Pessoa");
      else
        if (m == 81) Console.WriteLine("Recife");
        else
          if (m == 11) Console.WriteLine("São Paulo");
          else Console.WriteLine("Não cadastrada");

    switch (m) {
      case 84: Console.WriteLine("Natal"); break;
      case 83: Console.WriteLine("João Pessoa"); break;
      case 81: Console.WriteLine("Recife"); break;
      case 11: Console.WriteLine("São Paulo"); break;
      default: Console.WriteLine("Não cadastrada"); break;
    }
  }
}