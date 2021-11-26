using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite a média da disciplina");
    int m = int.Parse(Console.ReadLine());

    if (m < 0) {
      Console.WriteLine("Valor inválido");
    }
    if (m >= 0 && m <= 100) {
      Console.WriteLine("Valor válido");
    }
    if (m > 100) {
      Console.WriteLine("Valor inválido");
    }

    if (m < 0) {
      Console.WriteLine("Valor inválido");
    }
    else {  // m >= 0
      if (m <= 100)
        Console.WriteLine("Valor válido");
      else  // m > 100
        Console.WriteLine("Valor inválido");
    }

    /* Python
    if (m < 0)
      Console.WriteLine("Valor inválido");
    elif (m <= 100)
      Console.WriteLine("Valor válido");
    else  // m > 100
      Console.WriteLine("Valor inválido");
    */



  }
}
