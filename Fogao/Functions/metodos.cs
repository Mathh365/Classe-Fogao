namespace Funcs;

public static class Func
{
    //metodo responsavel por arredondar o valor de potencia fornecido 
    public static int ArredondaPotencia(int potenciaCrua, int valorMaximo)
    {
        if ((potenciaCrua >= 1) && (potenciaCrua <= valorMaximo)) return potenciaCrua;
        else if (potenciaCrua > valorMaximo) return valorMaximo;
        else if (potenciaCrua <= 1) return 1;
        return 1;
    }
}

