using System;

public class Program {
  public static void Main() {
    string s;

    /* solução 01
    do {
      s = Console.ReadLine();
      if (s == "2002")
        Console.WriteLine("Acesso Permitido");
      else
        Console.WriteLine("Senha Invalida");
    } while (s != "2002");
    */

    /* solução 02
    do {
      s = Console.ReadLine();
      if (s != "2002")
        Console.WriteLine("Senha Invalida");
    } while (s != "2002");
    Console.WriteLine("Acesso Permitido");
    */

    /* solução 03
    s = "0000";
    while (s != "2002") {
      s = Console.ReadLine();
      if (s == "2002")
        Console.WriteLine("Acesso Permitido");
      else
        Console.WriteLine("Senha Invalida");
    } 
    */

    /* solução 04
    s = Console.ReadLine();
    while (s != "2002") {
      Console.WriteLine("Senha Invalida");
      s = Console.ReadLine();
    } 
    Console.WriteLine("Acesso Permitido");
    */

    for (s = Console.ReadLine(); s != "2002"; s = Console.ReadLine()) {
      Console.WriteLine("Senha Invalida");
    }  
    Console.WriteLine("Acesso Permitido");


  }
}
