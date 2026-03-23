using System;

public class AviaoCargueiro : IAviao
{
    public void Transportar(string carga, int quantidade)
    {
        double tempo = quantidade / (double)Configuracao.Instancia.VelocidadeMedia; 
        Console.WriteLine($"Transportando {quantidade} unidades de '{carga}' no avião CARGUEIRO.");
        Console.WriteLine($"Tempo estimado de transporte: {tempo:0.##} horas");
    }
}
