using System;

class Program {
  public static void Main() {
    int x = 5;
    Console.WriteLine(x);

    var y = 1;   // Inferência de tipo
    var z = 1.5; // Tipos anônimos
    Console.WriteLine(y.GetType());
    Console.WriteLine(z.GetType());

    Quadrado q = new Quadrado();
    q.cor = "Verde";
    Console.WriteLine($"{q.cor} {q.GetLado()} {q.madeira}");

    Quadrado r = new Quadrado(10);
    Console.WriteLine(r.GetLado());
    r.SetLado(100);
    Console.WriteLine(r.GetLado());

    var s = new Quadrado();
    Console.WriteLine(s.GetType());
    s.SetLado(100);
    Console.WriteLine(s.ToString());

    q = null;

  }
}

class Quadrado : object {
  private int lado = 5;     // 0
  public string cor;   // null
  public bool madeira; // False
  public Quadrado() {
    this.lado = 15; // lado = 15;
  }
  public Quadrado(int valor) {
    this.lado = valor;
  }
  public void SetLado(int lado) {
    this.lado = lado;
  }
  public int GetLado() {
    return this.lado;
  }
  public override string ToString() {
    return $"Eu sou um quadrado e meu lado vale {lado}";
  }
}

