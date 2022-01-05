using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite seu nome");
    string nome = Console.ReadLine();

    Console.WriteLine(FormatarNome(nome));
 
/*
    nome = nome.ToLower();
    string[] v = nome.Split();
    // Console.WriteLine(v.Length); // len()
    // string resultado = string.Empty; 
    string resultado = "";
    for (int i = 0; i < v.Length; i++) {
      char primeiraLetra = char.ToUpper(v[i][0]);
      string cadaNome = v[i].Substring(1); // [1:]
      //Console.WriteLine(primeiraLetra);
      //Console.WriteLine(cadaNome);
      resultado = resultado + primeiraLetra + cadaNome + " ";
    }
    Console.WriteLine(resultado);
*/
  
    /*
    Console.WriteLine(v[1]);
    Console.WriteLine(v[2]);
    Console.WriteLine(v[3]); // Length - 1
    Console.WriteLine(v[4]); // Length
    */

    //Console.WriteLine(nome.ToUpper());
    //Console.WriteLine(nome.ToLower());
  }

  public static string FormatarNome(string nome) {
    nome = nome.ToLower();
    string[] v = nome.Split();
    string resultado = "";
    for (int i = 0; i < v.Length; i++) {
      char primeiraLetra = char.ToUpper(v[i][0]);
      string cadaNome = v[i].Substring(1); 
      resultado = resultado + primeiraLetra + cadaNome + " ";
    }
    return resultado;
  }
}


