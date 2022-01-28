using System;

class Program {
  public static void Main() {
    string s;
    while (!string.IsNullOrEmpty(s = Console.ReadLine())) {
    //string s = Console.ReadLine();
      string[] v = s.Split(' ');
      int n = int.Parse(v[0]);
      int m = int.Parse(v[1]);

      int[,] matriz = new int[n+2, m+2];
      int[,] result = new int[n+2, m+2];
      for (int i = 1; i <= n; i++) {
        s = Console.ReadLine();
        v = s.Split(' '); // v é cada linha da matriz e tem m elementos
        for (int j = 0; j < m; j++)
          matriz[i, j+1] = int.Parse(v[j]);
      }
      /*
      for (int i = 0; i <= n+1; i++) {
        for (int j = 0; j <= m+1; j++) 
          Console.Write(matriz[i,j] + "  ");
        Console.WriteLine();
      }
      */
      for (int i = 1; i <= n; i++) {
        for (int j = 1; j <= m; j++) {
          if (matriz[i,j] == 1) result[i,j] = 9;
          else {
            result[i,j] = matriz[i,j-1] + matriz[i,j+1] + matriz[i-1,j] + matriz[i+1,j];
          }
        }
      }

      for (int i = 1; i <= n; i++) {
        for (int j = 1; j <= m; j++) 
          Console.Write(result[i,j]);
        Console.WriteLine();
      }
    }
  }  
}