using System;

public class Program {
  public static void Main() {
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    string c = Console.ReadLine();
    string s = a + b + c;
    switch (s) {
      case "vertebradoavecarnivoro" : Console.WriteLine("aguia"); break;
      case "vertebradoaveonivoro" : Console.WriteLine("pomba"); break;
      //...
    }

    /*
    if (a == "vertebrado") {
      if (b == "ave") {
        if (c == "carnivoro") {
          Console.WriteLine("aguia");
        }
        if (c == "onivoro") {
          Console.WriteLine("pomba");
        }
      }
      if (b == "mamifero") {
      }
    }

    if (a == "invertebrado") {
    }
    */
  }
}
