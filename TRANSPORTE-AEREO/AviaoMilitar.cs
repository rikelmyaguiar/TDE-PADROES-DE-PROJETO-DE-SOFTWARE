using System;

public class AviaoMilitar : IAviao
{
    public void Transportar(string carga, int quantidade)
    {
        double tempo = quantidade / (double)Configuracao.Instancia.VelocidadeMedia;
        Console.WriteLine($"Transportando {quantidade} unidades de carga/missão no avião MILITAR.");
        Console.WriteLine($"Tempo estimado de missão: {tempo:0.##} horas");
    }
}
