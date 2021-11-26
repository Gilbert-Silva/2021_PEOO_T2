using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite a média da disciplina");
    int m = int.Parse(Console.ReadLine()); // if m >= 60:
    //bool x = m >= 60;

    if (m >= 60) {
      Console.WriteLine("Parabéns");
      Console.WriteLine("Aprovado");
    }
    else {
      Console.WriteLine("Se dedique mais");
      Console.WriteLine("Reprovado");
    }

    if (m < 60) {
      Console.WriteLine("Se dedique mais");
      Console.WriteLine("Reprovado");
    }
  }
}


