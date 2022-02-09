using System;

class Program {
  public static void Main() {
    Console.Write("Informe o número de contas: ");
    int n = int.Parse(Console.ReadLine());

    Agua[] vetor = new Agua[n];

    for (int i = 0; i < n; i++) {
      Console.Write("Informe o mês/ano: ");
      string ma = Console.ReadLine();
      Console.Write("Informe o consumo em m3: ");
      int c = int.Parse(Console.ReadLine());
      Console.Write("Informe o valor em R$: ");
      double v = double.Parse(Console.ReadLine());
      Agua a = new Agua(ma, c, v);
      vetor[i] = a;
    }
    int totalc = 0;
    double totalg = 0;
    foreach(Agua a in vetor) {
      totalc = totalc + a.GetConsumo();
      totalg = totalg + a.GetValor();
    }
    /*
    for (int i = 0; i < n; i++) {
      totalc = totalc + vetor[i].GetConsumo();
      totalg = totalg + vetor[i].GetValor();
    }
    */
    Console.WriteLine($"Consumo total em m3 - {totalc}");
    Console.WriteLine($"Total gasto em R$ - {totalg:0.00}");
  }
}

class Agua {
  private string mesAno;
  private int consumo;
  private double valor;
  public Agua(string ma, int c, double v) {
    this.mesAno = ma;
    this.consumo = c;
    this.valor = v;
  }
  public string GetMesAno() {
    return mesAno;
  }
  public int GetConsumo() {
    return consumo;
  }
  public double GetValor() {
    return valor;
  }
}

