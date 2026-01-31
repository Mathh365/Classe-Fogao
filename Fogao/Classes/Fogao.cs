using Funcs;
namespace classes;

public class Fogao
{
    private int PotenciaDoFogao;
    private List<Boca> Bocas;

    public Fogao(int nDeBocas, int potencia)
    {
        this.PotenciaDoFogao = func.ArredondaPotencia(potencia, 10);

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

    public void StatusDasBocas()
    {
        Console.WriteLine("Potencia maxima deste fogao (aplicada a todas as bocas): " + PotenciaDoFogao);

        for (int i = 0; i < Bocas.Count; i++)
        {
            Console.WriteLine($"""
            ---------------------------------------------------------
            Boca {i}

            Estado: {Bocas[i].Estado}
            Potencia na boca atualmente: {Bocas[i].PotenciaAtual}
            Potencia MAXIMA desta boca: {Bocas[i].PotenciaMaxima}
            """);
        }
    }
}