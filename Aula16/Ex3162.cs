using System;

class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    Nave[] vetor = new Nave[n];
    for(int i = 0; i < n; i++) {
      vetor[i] = new Nave(Console.ReadLine());
    }
    Nave x, y;
    double dist, menor;
    for(int i = 0; i < n; i++) {
      x = vetor[i];
      menor = double.MaxValue;
      for (int j = 0; j < n; j++) {
        y = vetor[j];
        if (i != j) {
          dist = Nave.Distancia(x, y);
          if (dist < menor) menor = dist; 
        }
      }
      if (menor <= 20) Console.WriteLine("A");
      else
        if (menor <= 50) Console.WriteLine("M");
        else Console.WriteLine("B");
    }
    /*
    Nave a = new Nave(50, 55, 55);
    Nave b = new Nave(15, 28, 79);
    a.Distancia(b);
    Nave.Distancia(a, b);
    */
  }
}
class Nave {
  private int x, y, z;
  public Nave(int x, int y, int z) {
    this.x = x; this.y = y; this.z = z;
  }
  public Nave(string s) {
    string[] v = s.Split(' ');
    x = int.Parse(v[0]);
    y = int.Parse(v[1]);
    z = int.Parse(v[2]);
  }
  public double Distancia(Nave n) {
    return Math.Sqrt(
      Math.Pow(this.x - n.x, 2) + Math.Pow(this.y - n.y, 2) + Math.Pow(this.z - n.z, 2));
  }
  public static double Distancia(Nave a, Nave b) {
    return Math.Sqrt(
      Math.Pow(a.x-b.x, 2) + Math.Pow(a.y-b.y, 2) + Math.Pow(a.z-b.z, 2));
  }
}