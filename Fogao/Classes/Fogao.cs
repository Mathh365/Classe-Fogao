using Funcs;
namespace classes;

public class Fogao
{
    readonly int PotenciaDoFogao;
    readonly List<Boca> Bocas;

    public Fogao(int nDeBocas, int potencia)
    {
        this.PotenciaDoFogao = Func.ArredondaPotencia(potencia, 10);

        Bocas = new List<Boca>();
        CriaBocas(nDeBocas);
    }

    private void CriaBocas(int nbocas)
    {
        for (int i = 0; i < nbocas; i++)
        {
            Bocas.Add(new Boca(PotenciaDoFogao));
        }
    }

    public void StatusGeral()
    {
        Console.WriteLine("Potencia maxima deste fogao (aplicada a todas as bocas): " + PotenciaDoFogao);

        for (int i = 0; i < Bocas.Count; i++)
        {
            Console.WriteLine($"""
            ---------------------------------------------------------
            Boca {i+1}

            Estado: {Bocas[i].Estado}
            Potencia na boca atualmente: {Bocas[i].PotenciaAtual}
            Potencia MAXIMA desta boca: {Bocas[i].PotenciaMaxima}
            """);
        }
    }

    public void StatusDaBoca(int numeroDaBoca)
    {
        int nDaBoca = numeroDaBoca - 1;
        Console.WriteLine($"""
            ---------------------------------------------------------
            Boca {numeroDaBoca}

            Estado: {Bocas[nDaBoca].Estado}
            Potencia na boca atualmente: {Bocas[nDaBoca].PotenciaAtual}
            Potencia MAXIMA desta boca: {Bocas[nDaBoca].PotenciaMaxima}
            ---------------------------------------------------------
            """);
    }
    
}