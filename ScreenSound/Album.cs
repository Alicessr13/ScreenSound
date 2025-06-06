class Album
{
    public string Nome { get; set; }
    public int DuracaoTotal => Musicas.Sum(m => m.Duracao);
    private List<Musica> Musicas = new List<Musica>();

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
            Console.WriteLine($"Música {musica.Nome} ({musica.Artista})");
        }
        Console.WriteLine($"\nDuração total do álbum: {DuracaoTotal} segundos");
    }
}