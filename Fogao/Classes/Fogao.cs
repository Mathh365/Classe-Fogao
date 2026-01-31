using Funcs;
namespace classes;

public class Fogao
{
    private int PotenciaDoFogao;
    private int nDeBocas;
    private List<Boca> Bocas;

    public Fogao(int numero, int potencia)
    {
        this.PotenciaDoFogao = func.ArredondaPotencia(potencia, 10);
        this.nDeBocas = numero;

        Bocas = new List<Boca>();
        CriaBocas(nDeBocas);
    }

    private void CriaBocas(int quantidade)
    {
        for (int i = 0; i < quantidade; i++)
        {
            Bocas.Add(new Boca(PotenciaDoFogao));
        }
    }

    public void StatusDasBocas()
    {
        Console.WriteLine("Potencia maxima deste fogao (aplicada a todas as bocas): " + PotenciaDoFogao);

        for (int i = 0; i < nDeBocas; i++)
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