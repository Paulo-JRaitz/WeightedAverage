using System;

namespace MediaPonderada
{
  class Program
  {
    static void Main(string[] args)
    {
      MediaPonderada CalcMediaPonderada = new MediaPonderada();
      double n1 = double.Parse(Console.ReadLine());
      double n2 = double.Parse(Console.ReadLine());
      double n3 = double.Parse(Console.ReadLine());
      double n4 = double.Parse(Console.ReadLine());
      CalcMediaPonderada.media(n1, n2, n3, n4);

    }
  }

}
