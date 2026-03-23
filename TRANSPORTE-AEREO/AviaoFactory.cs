using System;

public class AviaoFactory
{
    public static IAviao CriarAviao(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "cargueiro":
                return new AviaoCargueiro();
            case "passageiro":
                return new AviaoPassageiro();
            case "militar":
                return new AviaoMilitar();
            default:
                throw new Exception("Tipo de avião inválido!");
        }
    }
}
