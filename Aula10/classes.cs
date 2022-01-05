using System;
// Entrada e saída de dados - Usuário
class Program {
  public static void Main() {
    int a = 0;
    int b = 10;
    Console.WriteLine(a);
    Console.WriteLine(b);
    Triangulo x = new Triangulo();
    Console.WriteLine(x.GetBase());
    Console.WriteLine(x.GetAltura());
    //x.b = -10;
    //x.h = 20;
    x.SetBase(-10);
    x.SetAltura(20);
    Console.WriteLine(x.GetBase());
    Console.WriteLine(x.GetAltura());
    Triangulo y = null;
    y = new Triangulo();
    //y.b = 30;
    //y.h = 40;
    y.SetBase(30);
    y.SetAltura(40);
    //Console.WriteLine(x.b * x.h / 2);
    //Console.WriteLine(y.b * y.h / 2);
    Console.WriteLine(x.Area());
    Console.WriteLine(y.Area());
  }
}
// Modelo da entidade
class Triangulo {
  private double b;
  private double h;
  public void SetBase(double valor) {
    if (valor >= 0) b = valor;
  }
  public void SetAltura(double valor) {
    if (valor >= 0) h = valor;
  }
  public double GetBase() {
    return b;
  }
  public double GetAltura() {
    return h;
  }
  public double Area() {
    return b * h / 2;
  }
}

/*
class Triangulo:
    pass

x = Triangulo()
print(x)

<__main__.Triangulo object at 0x0000020641828F70>

*/