static int ContarPalavras(string texto)
{
    int palavras = 0;
    bool dentroDePalavra = false;

    for (int i = 0; i < texto.Length; i++)
    {
        if (texto[i] != ' ')
        {
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
    }

    return palavras;
}
