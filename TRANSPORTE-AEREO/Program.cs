using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"=== Sistema de Transporte Aéreo - {Configuracao.Instancia.NomeEmpresa} ===");
        Console.WriteLine("Tipos de avião disponíveis: Cargueiro, Passageiro, Militar");
        Console.Write("Digite o tipo de avião que deseja usar: ");
        string? tipo = Console.ReadLine()?.Trim().ToLower();

        if (string.IsNullOrWhiteSpace(tipo))
        {
            Console.WriteLine("Erro: você não digitou nenhum tipo de avião.");
            return;
        }

        try
        {
            IAviao aviao = AviaoFactory.CriarAviao(tipo);

            switch (tipo)
            {
                case "cargueiro":
                    Console.WriteLine("Peso da carga? (1 - leve, 2 - pesada, 3 - muito pesada)");
                    int peso = LerOpcaoPeso();
                    Console.Write("Digite a quantidade de cargas: ");
                    int qtdCarga = LerQuantidade();
                    aviao.Transportar($"Carga nível {peso}", qtdCarga);
                    break;

                case "passageiro":
                    Console.Write("Digite a quantidade de passageiros: ");
                    int qtdPassageiro = LerQuantidade();
                    aviao.Transportar("Passageiros", qtdPassageiro);
                    break;

                case "militar":
                    Console.Write("Será transporte de carga ou tropa? (digite 'carga' ou 'tropa'): ");
                    string? tipoMilitar = Console.ReadLine()?.Trim().ToLower();
                    if (tipoMilitar == "carga")
                    {
                        Console.WriteLine("Peso da carga? (1 - leve, 2 - pesada, 3 - muito pesada)");
                        int pesoMilitar = LerOpcaoPeso();
                        Console.Write("Digite a quantidade de cargas: ");
                        int qtdCargaMilitar = LerQuantidade();
                        aviao.Transportar($"Carga nível {pesoMilitar}", qtdCargaMilitar);
                    }
                    else if (tipoMilitar == "tropa")
                    {
                        Console.Write("Digite a quantidade de tropas: ");
                        int qtdTropa = LerQuantidade();
                        aviao.Transportar("Tropa", qtdTropa);
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida para militar!");
                    }
                    break;

                default:
                    Console.WriteLine("Tipo de avião inválido!");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

        Console.WriteLine("Operação finalizada. Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static int LerQuantidade()
    {
        int quantidade;
        while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
        {
            Console.Write("Quantidade inválida. Digite novamente: ");
        }
        return quantidade;
    }

    static int LerOpcaoPeso()
    {
        int opcao;
        while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3)
        {
            Console.Write("Opção inválida. Digite 1, 2 ou 3: ");
        }
        return opcao;
    }
}
