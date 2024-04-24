//para descobrirmos se um número faz parte da sequência de fibonacci, precisamos descobrir se o resultado de (5num^2 + 4) ou (5num^2 - 4) é um quadrado perfeito.


public static class AtividadeTarget
{
    public static string fibonacci(int num)
    {
        int prova = 5 * num * num + 4;
        int prova2 = 5 * num * num - 4;

        //através dessa variável booleana definimos se o número inserido faz parte ou não da sequência de fibonacci
        bool isFibonacci = équadradoPerfeito(prova) || équadradoPerfeito(prova2);

        if (isFibonacci)
        {
            return "É fibonacci";
        }
        else
            return "Não é fibonacci";
    }

    //este metódo descobre se um número é um quadrado perfeito
    static bool équadradoPerfeito(int x)
    {
        int s = (int)Math.Sqrt(x);
        return s * s == x;
    }
}

