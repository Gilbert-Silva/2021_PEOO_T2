using System;
using System.Globalization;
using System.Threading;

enum Cores { Preto, Azul, Vermelho, Verde }

class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

    Cores c1 = Cores.Preto;
    Cores c2 = Cores.Azul;
    Console.WriteLine(c1);
    Console.WriteLine(c2);

    int x = 4;
    DateTime d = DateTime.Now;
    Console.WriteLine(d);
    Console.WriteLine(d.Day);
    Console.WriteLine(d.Month);
    Console.WriteLine(d.Year);
    DateTime d2 = d.AddDays(10);
    Console.WriteLine(d2);
    DateTime d3 = DateTime.Parse("01/01/2021");
    Console.WriteLine(d3);
    Console.WriteLine(d3.DayOfWeek);
    TimeSpan t = TimeSpan.Parse("1:10:20:30");
    Console.WriteLine(t);
    Console.WriteLine(d3 + 3 * t);
    DateTime d4 = new DateTime();
    Console.WriteLine(d4);
  }
}