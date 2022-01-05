using System;

class Program {
  public static void Main() {
    Data d1 = new Data();
    d1.SetData(15, 12, 2021); // Mensagem
    Data d2 = new Data(10, 3, 2022);
    Data d3 = new Data("15/04/2019");
    // DateTime dt = new DateTime();
    //d1.dia = 35;
    //d1.mes = 12;
    //d1.ano = 2021;
    //int x = 5;
    //x = x;

    Console.WriteLine(d1.GetHashCode());
    Console.WriteLine(d2.GetHashCode());
    Console.WriteLine(d3.GetHashCode());
    if (d1.Equals(d2)) Console.WriteLine("Iguais");
    else Console.WriteLine("Diferentes");

    Console.WriteLine("Data 1 = " + d1);
    Console.WriteLine("Data 2 = " + d2);
    Console.WriteLine("Data 3 = " + d3);
    Console.WriteLine(d3.GetDia());
    Console.WriteLine(d3.GetMes());
    Console.WriteLine(d3.GetAno());

    d2 = d3;
    d3.SetData(5,5,2015);

    Console.WriteLine(d2); 
    // ?????? 10/03/2022 ou 15/04/2019 ou 05/05/2015


    // int.Parse("Teste");
    // Console.WriteLine(dt);
  }
}

//class Data : object {
class Data {
  private int dia = 2, mes = 2, ano = 2;
  public Data() { // Construtor padrão
    //this.dia = 1;
    dia = 1;
    mes = 1;
    ano = 1;
  }
  public Data(int d, int m , int a) {
    SetData(d, m, a);
    /*
    int max = 31;
    if (m == 2) max = 28;
    if (m == 4 || m == 6 || m == 9 || m == 11) max = 30;
    if (d >= 1 && d <= max) dia = d;
    // else throw new ArgumentOutOfRangeException("Dia é inválido");
    if (m >= 1 && m <= 12) mes = m;
    if (a >= 1900) ano = a;
    */
  }
  public Data(string data) {
    string[] v = data.Split("/");
    int d = int.Parse(v[0]);
    int m = int.Parse(v[1]);
    int a = int.Parse(v[2]);
    SetData(d, m, a);
  }
  public int GetDia() {
    return dia;
  }
  public int GetMes() {
    return mes;
  }
  public int GetAno() {
    return ano;
  }
  public void SetData(int dia, int mes, int ano) {
    Console.WriteLine("Antes: " + this);
    int max = 31;
    if (mes == 2) max = 28;
    if (mes == 4 || mes == 6 || mes == 9 || mes == 11) max = 30;
    if (dia >= 1 && dia <= max) this.dia = dia;
    // else throw new ArgumentOutOfRangeException("Dia é inválido");
    if (mes >= 1 && mes <= 12) this.mes = mes;
    if (ano >= 1900) this.ano = ano;
    Console.WriteLine("Depois: " + this);
  }
  public override string ToString() { // Polimorfismo - Sobrescrever
    //return $"Dia={dia} Mês={mes} Ano={ano}";
    return $"{this.dia:00}/{mes:00}/{ano:0000}";
  }
}