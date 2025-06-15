namespace ScreenSound.Models;

class Banda
{
    public string Nome { get; }
    private List<Album> albuns = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda: {Nome}");
        foreach (var album in albuns)
        {
            //album.ExibirMusicas();
            Console.WriteLine($"Álbum: {album.Nome}");
        }
    }
}