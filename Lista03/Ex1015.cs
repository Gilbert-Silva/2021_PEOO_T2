using System;

public class Program {
  public static void Main() {
    string s1 = Console.ReadLine();
    string[] v1 = s1.Split(' ');
    double x1 = double.Parse(v1[0]);
    double y1 = double.Parse(v1[1]);

    string s2 = Console.ReadLine();
    string[] v2 = s2.Split(' ');
    double x2 = double.Parse(v2[0]);
    double y2 = double.Parse(v2[1]);

    double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + 
      Math.Pow(y2 - y1, 2));
     
    //Console.WriteLine(d.ToString("0.0000"));
    //Console.WriteLine($"{d:0.0000}");
    Console.WriteLine($"{d:f4}");
  }
}