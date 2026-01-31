namespace classes;

class Boca
{
    public int PotenciaMaxima {get; private set;}
    public int PotenciaAtual {get; private set;}
    public bool Estado {get; private set;}

    public Boca (int potenciaMaxima)
    {
        this.PotenciaMaxima = ArredondadorDePotencia(potenciaMaxima);
        Console.WriteLine($"A potencia Maxima desta boca agora é {this.PotenciaMaxima}");
        
        this.Estado = false;
    }

    private int ArredondadorDePotencia (int num)
    {
        if ((num >= 1) && (num <= 10)) return num;
        else if (num > 10) return 10;
        else if (num <= 1) return 1;
        return 1;
    }

    public void Ascender (int potencia)
    {
        if (!this.Estado)
        {
            this.Estado = true;
            this.PotenciaAtual = ArredondadorDePotencia(potencia);
        } else
        {
            Console.WriteLine("Esta boca ja esta acesa");
        }
    }

    public void Apagar()
    {
        if (this.Estado)
        {
            this.Estado = false;
            this.PotenciaAtual = 0;
        } else
        {
            Console.WriteLine("Esta boca ja esta apagada");
        }
    }
}


