using System;

class Program {
  public static void Main() {
    Aluno a1 = new Aluno();
    a1.SetNome("Henrique");
    a1.SetMatricula("98769876");
    a1.SetIdade(17);
    Console.WriteLine(a1.GetNome());
    Console.WriteLine(a1.GetMatricula());
    Console.WriteLine(a1.GetIdade());

    Aluno a2 = new Aluno();
    a2.SetNome("Rafael");
    a2.SetMatricula("463456");
    a2.SetIdade(16);
    Console.WriteLine(a2.GetNome());
    Console.WriteLine(a2.GetMatricula());
    Console.WriteLine(a2.GetIdade());

    Aluno2 b1 = new Aluno2();
    // b1.SetNome("Ramon");
    b1.Nome = "Ramon";          // SET
    b1.Matricula = "9832452";
    b1.Idade = 19;
    Console.WriteLine(b1.Nome); // GET
    Console.WriteLine(b1.Matricula);
    Console.WriteLine(b1.Idade);

    Aluno2 b2 = new Aluno2();
    b2.Nome = "Raquel";          // SET
    b2.Matricula = "3465345";
    b2.Idade = 18;
    Console.WriteLine(b2.Nome); // GET
    Console.WriteLine(b2.Matricula);
    Console.WriteLine(b2.Idade);

    Aluno3 c1 = new Aluno3();
    c1.Nome = "Sabrina";          // SET
    c1.Matricula = "34563456";
    c1.Idade = 17;
    Console.WriteLine(c1.Nome); // GET
    Console.WriteLine(c1.Matricula);
    Console.WriteLine(c1.Idade);

    Aluno3 c2 = new Aluno3 { Nome = "Sergio", Matricula = "8954856", Idade = 18 };
    //Aluno3 c2 = new Aluno3("Sergio", "8954856", 18);
    Console.WriteLine(c2.Nome); // GET
    Console.WriteLine(c2.Matricula);
    Console.WriteLine(c2.Idade);
  }
}

class Aluno {  // Atributos e métodos
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
}

class Aluno2 {  // Atributos e propriedades
  private string nome;
  private string matricula;
  private int idade;
  public string Nome {
    set { this.nome = value; }
    get { return nome; }
  }
  public string Matricula {
    set { this.matricula = value; }
    get { return matricula; }
  }
  public int Idade {
    set { if (value > 0) this.idade = value;
          else this.idade = 0; }
    get { return idade; }
  }
}

class Aluno3 {  // Propriedades auto implementadas - Validação é feita de outra forma
  //public Aluno3(string nome, string mat, int idade) {
  //}
  // POCO - POJO: Plain Old C#/Java Object
  public string Nome { get; set; }
  public string Matricula { get; set; }
  public int Idade { get; set; }
}



