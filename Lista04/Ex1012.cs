using System;

public class Program {
  public static void Main() {
    /*
    DateTime d = DateTime.Now;
    Console.WriteLine(d);
    Console.WriteLine($"{d:dd/MM/yyyy}");
    Console.WriteLine($"{d:ddd/MMM/yyyy}");
    Console.WriteLine($"{d:dddd/MMMM/yyyy}");
    Console.WriteLine($"{d:dddd/MMMM/yyyy hh:mm:ss}");
    */
    string s = Console.ReadLine();
    string[] v = s.Split(' ');
    double a = double.Parse(v[0]);
    double b = double.Parse(v[1]);
    double c = double.Parse(v[2]);
    Console.WriteLine($"TRIANGULO: {a*c/2:f3}");
    Console.WriteLine($"CIRCULO: {3.14159*c*c:0.000}");
    Console.WriteLine($"TRAPEZIO: {(a+b)*c/2:0.000}");
    Console.WriteLine($"QUADRADO: {Math.Pow(b, 2):0.000}");
    Console.WriteLine($"RETANGULO: {a*b:0.000}");
  }
}