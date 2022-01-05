using System;
// Entrada e saída de dados - Usuário
class Program {
  public static void Main() {
    Triangulo x = new Triangulo();
    x.SetBase(10);
    x.SetAltura(20);
    Triangulo y = new Triangulo();
    y.SetBase(30);
    y.SetAltura(40);
    x = y;
    Console.WriteLine(x.Area()); //600
    x.SetBase(20); 
    Console.WriteLine(y.Area()); //600
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