namespace ScreenSound.Models;

public class Podcast
{
    public string Host { get; }
    public string Nome { get; }
    public List<Episodio> Episodios { get; set; }
    public int TotalEpisodios => Episodios?.Count ?? 0;

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
        Episodios = new List<Episodio>();
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        if (Episodios == null)
        {
            Episodios = new List<Episodio>();
        }
        Episodios.Add(episodio);
    }

    public void ExibirPodcast()
    {
        Console.WriteLine($"Podcast: {Nome}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
        if (Episodios != null && Episodios.Count > 0)
        {
            foreach (var episodio in Episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine($"- {episodio.Resumo}");
            }
        }
        else
        {
            Console.WriteLine("Nenhum episódio disponível.");
        }
    }
}
