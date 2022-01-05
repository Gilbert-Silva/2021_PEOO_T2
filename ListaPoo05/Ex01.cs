using System;
using System.Globalization;
using System.Threading;

class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    Paciente p = new Paciente("Nome", "123456789", "8888-8888", DateTime.Parse("10/04/2000"));
    Console.WriteLine(p);
    Console.WriteLine(p.Idade());
  }
}
class Paciente {
  private string nome, cpf, telefone;
  private DateTime nascimento;
  public Paciente(string n, string c, string t, DateTime d) {
    nome = n;
    cpf = c;
    telefone = t;
    nascimento = d;
  }
  public string Idade() {
    DateTime hoje = DateTime.Now;
    int a = hoje.Year - nascimento.Year;
    int m = hoje.Month - nascimento.Month;
    if (m < 0) {
      m = m + 12;
      a--;
    }
    //return $"{a} ano(s) e {m} mes(es)";
    TimeSpan t = hoje - nascimento;
    a = t.Days / 365;
    m = (t.Days - a * 365) / 30;
    return $"{a} ano(s) e {m} mes(es)";
  }
  public override string ToString() {
    return $"{nome} - {cpf} - {telefone} - {nascimento}";
  }
}
