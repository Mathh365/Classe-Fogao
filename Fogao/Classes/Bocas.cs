using Funcs;
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
        this.Estado = false;
        this.PotenciaMaxima = potenciaInserida;
    }

        //metodo que ascende a boca, alterando o estado da mesma, respeitando os limites fisicos do hardware
    public void Acender (int potencia)
    {
        if (!this.Estado)
        {
            this.Estado = true;
            this.PotenciaAtual = func.ArredondaPotencia(potencia, PotenciaMaxima);
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

