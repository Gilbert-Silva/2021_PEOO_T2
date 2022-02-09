using System;

class Program {
  public static void Main() {
    Aluno a1 = new Aluno();
    a1.SetNome("Raquel");
    a1.SetMatricula("3465345");
    a1.SetIdade(18);

    Aluno a2 = new Aluno();
    a2.SetNome("Rafael");
    a2.SetMatricula("2463456");
    a2.SetIdade(16);
 
    Aluno a3 = new Aluno();
    a3.SetNome("Henrique");
    a3.SetMatricula("98769876");
    a3.SetIdade(17);

    Aluno[] va = { a1, a2, a3 };
    Array.Sort(va);
    foreach(Aluno a in va) {
      Console.Write(a.GetNome() + " - ");
      Console.Write(a.GetMatricula() + " - ");
      Console.WriteLine(a.GetIdade());
    }

    int[] vi = { 4, 8, 1, 3, 9, 6 };
    Array.Sort(vi);
    foreach(int i in vi) {
      Console.WriteLine(i);
    }
  
    Console.WriteLine(1.CompareTo(2)); // -1
    Console.WriteLine(1.CompareTo(1)); // 0
    Console.WriteLine(2.CompareTo(1)); // 1

    Console.WriteLine(a1.CompareTo(a2)); 
    Console.WriteLine(a1.CompareTo(a1)); 
    Console.WriteLine(a2.CompareTo(a1)); 
  }
}

/*
interface IComparable {
  int CompareTo(object obj);
}
*/

class Aluno : IComparable {  // Atributos e métodos
  private string nome;
  private string matricula;
  private int idade;
  public void SetNome(string nome) {
    this.nome = nome;
  }  
  public void SetMatricula(string matricula) {
    this.matricula = matricula;
  }  
  public void SetIdade(int idade) {
    if (idade > 0) this.idade = idade;
    else this.idade = 0;
  } 
  public string GetNome() {
    return nome;
  } 
  public string GetMatricula() {
    return matricula;
  } 
  public int GetIdade() {
    return idade;
  } 
  public int CompareTo(object obj) {
    // this - a1
    // obj  - a2 -> Aluno
    // Typecast
    Aluno x = (Aluno) obj;
    if (this.idade < x.idade) return -1;
    if (this.idade > x.idade) return 1;
    return 0;
  }
}
