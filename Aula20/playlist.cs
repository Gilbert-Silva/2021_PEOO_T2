using System;

class Program {
  public static void Main() {
    Musica m1 = new Musica("Transilvania", "Iron Maiden", new TimeSpan(0, 0, 5, 30));
    Musica m2 = new Musica("Iron Maiden", "Iron Maiden", new TimeSpan(0, 0, 6, 40));
    Musica m3 = new Musica("Easy", "Ivete Sangalo", new TimeSpan(0, 0, 6, 15));

    Console.WriteLine(m1);
    Console.WriteLine(m2);
    Console.WriteLine(m3);

    PlayList pl = new PlayList();
    pl.Inserir(m1);
    pl.Inserir(m2);
    pl.Inserir(m3);
    Console.WriteLine(pl.Listar());
    foreach(Musica m in pl.Listar())
      Console.WriteLine(m);
    Console.WriteLine(pl.TempoTotal()); 
    foreach(Musica m in pl.Pesquisar("I"))
      Console.WriteLine(m);
  }
}

class PlayList {
  private Musica[] vetor = new Musica[10];
  private int qtd = 0;
  public void Inserir(Musica m) {
    if (qtd < 10) {
      vetor[qtd] = m;
      qtd++;
    }
  }
  public Musica[] Listar() {
    Musica[] aux = new Musica[qtd];
    Array.Copy(vetor, aux, qtd);
    //return vetor;
    return aux;
  }
  public TimeSpan TempoTotal() {
    TimeSpan t = new TimeSpan(); // t = 0
    foreach(Musica m in vetor)   // itera no vetor 
      if (m != null) t = t + m.GetDuracao();
    return t;
  }
  public Musica[] Pesquisar(string artista) {
    int k = 0;
    foreach(Musica m in vetor)   // itera no vetor 
      //if (m != null && m.GetArtista() == artista) k++;
      if (m != null && m.GetArtista().StartsWith(artista)) k++;
    Musica[] aux = new Musica[k];
    int n = 0;
    foreach(Musica m in vetor)   // itera no vetor 
      //if (m != null && m.GetArtista() == artista) {
      if (m != null && m.GetArtista().StartsWith(artista)) {
        aux[n] = m;
        n++;
      }
    return aux;  
  }
}

class Musica {
  private string titulo;
  private string artista;
  private TimeSpan duracao;
  public Musica(string t, string a, TimeSpan d) {
    this.titulo = t;
    artista = a;
    duracao = d;
  }
  public TimeSpan GetDuracao() {
    return duracao;
  }
  public string GetArtista() {
    return artista;
  }
  public override string ToString() {
    return $"{titulo} - {artista} - {duracao}";
  }
}