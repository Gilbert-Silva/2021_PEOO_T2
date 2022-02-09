using System;

class Program {
  public static void Main() {
    Pessoa p1 = new Pessoa("P1", "E1", false);
    Pessoa p2 = new Pessoa("P2", "E2", false);
    Pessoa p3 = new Pessoa("P3", "E3", false);
    //Console.WriteLine(p1);
    //Console.WriteLine(p2);
    //Console.WriteLine(p3);
    
    Equipe e = new Equipe("Equipe");
    e.Inserir(p1);
    e.Inserir(p2);
    e.Inserir(p3);
    foreach(Pessoa p in e.Listar())
      Console.WriteLine(p);
    Console.WriteLine(e.Lider());  
    
  }
}

class Equipe {
  private string nome;
  private Pessoa[] vetor = new Pessoa[10];
  private int k;
  public Equipe(string n) {
    this.nome = n;
  }
  public void Inserir(Pessoa p) {
    if (Lider() == null || p.GetLider()==false)
      if (k < 10) {
        vetor[k] = p;
        k++;
      }
  }
  public Pessoa[] Listar() {
    Pessoa[] aux = new Pessoa[k];
    Array.Copy(vetor, aux, k);
    return aux;
  }
  public Pessoa Lider() {
    foreach(Pessoa p in vetor) {
      if (p != null && p.GetLider()) return p;
    }
    return null;
  }
}

class Pessoa {
  private string nome;
  private string email;
  private bool lider;
  public Pessoa(string n, string e, bool l) {
    this.nome = n;
    this.email = e;
    this.lider = l;
  }
  public bool GetLider() {
    return lider;
  }
  public override string ToString() {
    return $"{nome} - {email} - {lider}";
  }
  
}
