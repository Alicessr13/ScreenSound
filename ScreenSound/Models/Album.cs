namespace ScreenSound.Models;

public class Album : IAvaliavel
{
    public string Nome { get; }
    public int DuracaoTotal => Musicas.Sum(m => m.Duracao);
    private List<Musica> Musicas = new List<Musica>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public Banda Banda { get; }

    public Album(string nome, Banda banda)
    {
        Nome = nome;
        Banda = banda;
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

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public double Media => notas.Count > 0 ? notas.Average(x => x.Nota) : 0;
}