using System;

public class AviaoPassageiro : IAviao
{
    public void Transportar(string carga, int quantidade)
    {
        double tempo = quantidade / (double)Configuracao.Instancia.VelocidadeMedia;
        Console.WriteLine($"Transportando {quantidade} passageiros no avião PASSAGEIRO.");
        Console.WriteLine($"Tempo estimado de voo: {tempo:0.##} horas");
    }
}
