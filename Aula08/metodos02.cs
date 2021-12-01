using System;

public class Program {
  int x;  // Atributo

  public static void Main(string[] args) {
    Console.WriteLine("Técnico \tem \nInformática para \tInternet");
    Console.WriteLine()

    Console.WriteLine("Digite seu nome");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite a cidade onde nasceu");
    string cidade = Console.ReadLine();

    //nome = nome.Trim();
    //cidade = cidade.Trim();

/*
    int x;
    do {
      x = nome.IndexOf("  ");
      // Console.WriteLine(x);    
      if (x != -1) nome = nome.Remove(x, 1);
    } while (x != -1);  

    do {
      x = cidade.IndexOf("  ");
      // Console.WriteLine(x);    
      if (x != -1) cidade = cidade.Remove(x, 1);
    } while (x != -1);  
    //Console.WriteLine(nome);    
  */
    nome = Formatar(nome);
    cidade = Formatar(cidade);

    Console.WriteLine($"Nome: {nome} - Cidade: {cidade}");
  }

  public static string Formatar(string s) {
    int x;
    s = s.Trim();
    // Remover um espaço qdo houver dois espaços juntos
    do {
      x = s.IndexOf("  ");
      // Console.WriteLine(x);    
      if (x != -1) s = s.Remove(x, 1);
    } while (x != -1);  
    // Remover tabulação
    do {
      x = s.IndexOf('\t');
      // Console.WriteLine(x);    
      if (x != -1) s = s.Remove(x, 1);
    } while (x != -1);  
    return s;
  }
}