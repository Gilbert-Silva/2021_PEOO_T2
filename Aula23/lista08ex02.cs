using System;

class Program {
  public static void Main() {
    Pais p1 = new Pais("Brasi", 6, 5, 6);
    Pais p2 = new Pais("Argen", 5, 5, 10);
    Pais p3 = new Pais("Russi", 4, 5, 6);
    Pais p4 = new Pais("Japao", 5, 5, 7);
    Pais p5 = new Pais("Alema", 4, 5, 6);
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);
    Console.WriteLine(p4);
    Console.WriteLine(p5);
    Console.WriteLine(p3.CompareTo(p1));
    Console.WriteLine(p3.CompareTo(p2));
    Console.WriteLine(p3.CompareTo(p4));

    Pais[] vp = { p1, p2, p3, p4, p5 };
    Array.Sort(vp);
    foreach(Pais p in vp)
      Console.WriteLine(p);
  }
}

class Pais : IComparable {
  private string nome;
  private int ouro, prata, bronze;
  public Pais(string n, int o, int p, int b) {
    nome = n;
    if (o > 0) ouro = o;
    if (p > 0) prata = p;
    if (b > 0) bronze = b;
  }
  public override string ToString() {
    return $"{nome} - Ouro = {ouro} - Prata = {prata} - Bronze = {bronze}";
  }
  public int CompareTo(object obj) {
    // this  - 1º obj
    // obj x - 2º obj -> Pais
    Pais x = (Pais) obj;
    // Decrescente Ouro, Prata, Bronze
    if (this.ouro > x.ouro) return -1;
    if (this.ouro < x.ouro) return 1;
    if (this.prata > x.prata) return -1;
    if (this.prata < x.prata) return 1;
    if (this.bronze > x.bronze) return -1;
    if (this.bronze < x.bronze) return 1;
    // Crescente Nome
    // if (this.nome > x.nome) return 1;
    // if (this.nome < x.nome) return -1;
    // return 0;
    // if(this.nome.CompareTo(x.nome) == -1) return -1;
    // if(this.nome.CompareTo(x.nome) == 1) return 1;
    // if(this.nome.CompareTo(x.nome) == 0) return 0;
    return this.nome.CompareTo(x.nome);

  }
}