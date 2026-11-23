class Program
static int ContarPalavras(string texto)
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma palavra:");
        string texto = Console.ReadLine();
        Console.WriteLine($"A palavra tem {ContarVogais(texto)} vogais");
    }
    int palavras = 0;
    bool dentroDePalavra = false;

    static int ContarVogais(string texto)
    for (int i = 0; i < texto.Length; i++)
{
        int vogais = 0;
        for (int i = 0; i < texto.Length; i++)
        if (texto[i] != ' ')
{
            char letra = texto[i];
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                vogais++;
            if (!dentroDePalavra)
            {
                palavras++;
                dentroDePalavra = true;
            }
        }
        else
        {
            dentroDePalavra = false;
}
        return vogais;
}

    return palavras;
}
