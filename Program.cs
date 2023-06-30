Console.WriteLine("***** DIGITE 5 NOMES E FAÇA A ESCOLHA DE UM EXISTENTE *****");
void EscolheNome()
{
    string[] nomes = new string[5];

    for (int i = 0; i < nomes.Length; i++)
    {
        Console.Write($"Escolha o {i + 1}º nome: ");
        nomes[i] = Console.ReadLine();
    }

    Console.Write("Qual nome você deseja escolher? ");
    var busca = Console.ReadLine();

    foreach (string palavra in nomes)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Parabéns,o nome {busca} existe no seu banco de dados.");
            return;
        }
    }
}

EscolheNome();