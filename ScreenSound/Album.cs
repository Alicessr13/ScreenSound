class Album
{
    public string Nome { get; }
    public int DuracaoTotal => Musicas.Sum(m => m.Duracao);
    private List<Musica> Musicas = new List<Musica>();
    public Banda Banda { get; }

    public Album(string nome, Banda banda)
    {
        Nome = nome;
        Banda = banda;
        banda.AdicionarAlbum(this);
    }

    public void AdicionarMusica(Musica musica)
    {
       Musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Álbum: {Nome}");
        Console.WriteLine("\nLista de músicas:");
        foreach (var musica in Musicas)
        {
            Console.WriteLine($"Música {musica.Nome} ({musica.Artista.Nome})");
        }
        Console.WriteLine($"\nDuração total do álbum: {DuracaoTotal} segundos");
    }
}