namespace MediaPonderada
{
  public class MediaPonderada
  {
    public double media(double _notaUm = 0.0, double _notaDois = 0.0, double _notaTres = 0.0, double _notaQuatro = 0.0)
    {
      double CalcMedia;
      int pesoUm = 1, pesoDois = 2, pesoTres = 3, pesoQuatro = 4;
      CalcMedia = (_notaUm * pesoUm + _notaDois * pesoDois + _notaTres * pesoTres + _notaQuatro * pesoQuatro) / (pesoUm + pesoDois + pesoTres + pesoQuatro);

      if (CalcMedia > 8.5)
      {
        System.Console.WriteLine($"Sua média de {CalcMedia} é Alta, parabéns!");
      }
      else
        if (CalcMedia >= 7.5 && CalcMedia <= 8.5)
      {
        System.Console.WriteLine($"Sua média de {CalcMedia} é Ideal, mas você pode melhorar!");
      }
      else if (CalcMedia < 7.5)
      {
        System.Console.WriteLine($"Sua média de {CalcMedia} é Baixa, pratique mais!");
      }
      return CalcMedia;
    }
  }
}