namespace classes;

public class Boca
        //definindo as propriedades da boca do fogao
{   public int PotenciaMaxima {get; private set;} 
    public int PotenciaAtual {get; private set;}
    public bool Estado {get; private set;}

        //inicializa a classe com a boca desligada, solicitando um valor para a potencia maxima (que sera usado posteriormente) e usa um metodo para tratar este valor, definindo a potencia maxima sempre entre 1-10
    public Boca (int potenciaInserida)
    {
        this.PotenciaAtual = 0;
        this.PotenciaMaxima = ArredondadorDePotencia(potenciaInserida, 10);        
        this.Estado = false;
    }

        //metodo responsavel por arredondar o valor de potencia fornecido 
    private int ArredondadorDePotencia (int num, int valorMaximo)
    {
        if ((num >= 1) && (num <= valorMaximo)) return num;
        else if (num > valorMaximo) return valorMaximo;
        else if (num <= 1) return 1;
        return 1;
    }

        //metodo que ascende a boca, alterando o estado da mesma, respeitando os limites fisicos do hardware
    public void Acender (int potencia)
    {
        if (!this.Estado)
        {
            this.Estado = true;
            this.PotenciaAtual = ArredondadorDePotencia(potencia, PotenciaMaxima);
        } else
        {
            Console.WriteLine("Esta boca ja esta acesa");
        }
    }

        //metodo para desligar a boca, alterando suas propriedades de estado e potencia
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


