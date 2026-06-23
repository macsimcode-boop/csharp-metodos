class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma palavra:");
        string texto = Console.ReadLine();
        Console.WriteLine($"A palavra tem {ContarVogais(texto)} vogais");
    }

    static int ContarVogais(string texto)
    {
        int vogais = 0;
        for (int i = 0; i < texto.Length; i++)
        {
            char letra = texto[i];
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                vogais++;
        }
        return vogais;
    }
}
