using System;

class Program {
  public static void Main() {
    /*
    Tipos por Valor
    struct: int, double, bool, char
    enum
    Tipos por Referência
    class
    string
    */
    int x = 5;
    int y = 10;
    string s = "Teste";
    string r = "123";
    Console.WriteLine(x + y);
    Console.WriteLine(s + r);
    Professor p = new Professor();
    Professor q = new Professor();
    q = p;
    p.SetIdade(35);
    Aluno a, b;
    a.idade = 20;
    b = a;
  }
}

class Professor {
  private int idade;
  public void SetIdade(int idade) {
    this.idade = idade;
  }
}
struct Aluno {
  private int idade;
}