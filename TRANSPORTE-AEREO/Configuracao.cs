public class Configuracao
{
    private static Configuracao? instancia;

    public string NomeEmpresa { get; private set; }
    public int VelocidadeMedia { get; private set; } 

    private Configuracao()
    {
        NomeEmpresa = "Logistica Aérea XYZ";
        VelocidadeMedia = 500; 
    }

    public static Configuracao Instancia
    {
        get
        {
            if (instancia == null)
                instancia = new Configuracao();
            return instancia;
        }
    }
}
