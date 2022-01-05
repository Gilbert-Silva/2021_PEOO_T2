using System;
using System.Collections;

class Program {
  public static void Main(string[] args) {
    Console.WriteLine(args.Length);
    //Console.WriteLine(args[0]);
    //Console.WriteLine(args[1]);
    //Console.WriteLine(args[2]);
    int num = int.Parse(Console.ReadLine());
    int[] v = new int[num];

    v[0] = 5;
    v[3] = 18;
    v[9] = 3;
    //v[4] = "Texto";
    Console.WriteLine("Elementos do Vetor");
    for(int k = 0; k <= 9; k++)
      Console.WriteLine($"v[{k}] = {v[k]}");

    foreach(int elem in v)
      Console.WriteLine(elem);  

    IEnumerator e = v.GetEnumerator();
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.Current);
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.Current);
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.Current);
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.MoveNext());
    Console.WriteLine(e.MoveNext());

    /*
    Console.WriteLine($"v[0] = {v[0]}");
    Console.WriteLine($"v[1] = {v[1]}");
    Console.WriteLine($"v[2] = {v[2]}");
    Console.WriteLine($"v[3] = {v[3]}");
    Console.WriteLine($"v[4] = {v[4]}");
    Console.WriteLine($"v[5] = {v[5]}");
    Console.WriteLine($"v[6] = {v[6]}");
    Console.WriteLine($"v[7] = {v[7]}");
    Console.WriteLine($"v[8] = {v[8]}");
    Console.WriteLine($"v[9] = {v[9]}");
    */
    string[] w = new string[4];
    w[0] = "C#";
    w[1] = "Java";
    w[2] = "Python";
    w[3] = "Javascript";
    //w[1] = 5;
    Console.WriteLine(w[0]);
    Console.WriteLine(w[1]);
    Console.WriteLine(w[2]);
    Console.WriteLine(w[3]);

    Console.WriteLine(v.Length);
    Console.WriteLine(w.Length);
    Console.WriteLine(v);
    Console.WriteLine(w);

    object[] x = new object[5];
    x[0] = 10;
    x[1] = "Texto";
    x[2] = 2.5;
    x[3] = true;
    x[4] = w;

    Console.WriteLine(x);
    // Type-cast
    Console.WriteLine(x[0]);
    Console.WriteLine(x[1]);
    Console.WriteLine(x[2]);
    Console.WriteLine(x[3]);
    Console.WriteLine(x[4]);

    int[,] matriz = new int[3,4];
    matriz[0,0] = 1;
    matriz[1,2] = 3;
    matriz[2,1] = 4;

    Console.Write(matriz[0,0] + "  ");
    Console.Write(matriz[0,1] + "  ");
    Console.Write(matriz[0,2] + "  ");
    Console.Write(matriz[0,3] + "  ");
    Console.WriteLine();
    Console.Write(matriz[1,0] + "  ");
    Console.Write(matriz[1,1] + "  ");
    Console.Write(matriz[1,2] + "  ");
    Console.Write(matriz[1,3] + "  ");
    Console.WriteLine();
    Console.Write(matriz[2,0] + "  ");
    Console.Write(matriz[2,1] + "  ");
    Console.Write(matriz[2,2] + "  ");
    Console.Write(matriz[2,3] + "  ");
    Console.WriteLine();

    for (int l = 0; l <= 2; l++) {
      for (int c = 0; c <= 3; c++) {
        Console.Write(matriz[l,c] + "  ");
      }
      Console.WriteLine();
    }


    /*
    string s = "Linguagem C#";
    s = s + "alguma coisa";
    //s[0] = "D";
    object r = s;
    Console.WriteLine(s[0]);
    //Console.WriteLine(r[0]);
    string t = s;
    t = "Java";
    s = "Python";
    //int x = 5;
    //Console.WriteLine(x);
    //x = 10;
    //Console.WriteLine(x + 10);
    */
  }
}