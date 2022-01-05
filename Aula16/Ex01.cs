using System;

class Program {
  public static void Main() {
    Console.Write("Informe o número de países: ");
    int k = int.Parse(Console.ReadLine());
    Pais[] vetor = new Pais[k];
    for (int i = 0; i < k; i++) {
      Console.WriteLine($"Informe os dados do {i+1}º país");
      string nome;
      int habs;
      double area;
      Console.Write("Nome: ");
      nome = Console.ReadLine();
      Console.Write("Número de habitantes: ");
      habs = int.Parse(Console.ReadLine());
      Console.Write("Área: ");
      area = double.Parse(Console.ReadLine());
      Pais p = new Pais(nome, habs, area);
      vetor[i] = p;
    }
    Pais maiorHab = vetor[0];
    for (int i = 1; i < k; i++) 
      if (vetor[i].GetHabitantes() > maiorHab.GetHabitantes())
        maiorHab = vetor[i];

    int maior = 0;
    for (int i = 1; i < k; i++) 
      if (vetor[i].GetHabitantes() > vetor[maior].GetHabitantes())
        maior = i;

    Pais maiorArea = vetor[0];
    foreach(Pais p in vetor)  
      if (p.GetArea() > maiorArea.GetArea()) maiorArea = p;

    Console.WriteLine($"Mais populoso: {maiorHab}");
    Console.WriteLine($"Mais populoso: {vetor[maior]}");

    Console.WriteLine($"Maior área: {maiorArea}");
    /*
    Pais a = new Pais("Brasil", 209000000, 8500000);
    Pais b = new Pais("Russia", 144000000, 17000000);
    Console.WriteLine(a);
    Console.WriteLine(b);
    */
  }
}

class Pais {
  private string nome;
  private int habitantes;
  private double area;
  public Pais(string nome, int habitantes, double area) {
    this.nome = nome;
    if (habitantes > 0) this.habitantes = habitantes;
    if (area > 0) this.area = area; 
  }
  public int GetHabitantes() {
    return habitantes;
  }
  public double GetArea() {
    return area;
  }
  public override string ToString() {
    return $"{nome} - {habitantes} habs - {area} km2";
  }
}