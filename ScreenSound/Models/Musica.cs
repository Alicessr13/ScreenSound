namespace ScreenSound.Models;

class Musica
{
    public string Nome { get; }
    public Banda Artista { get; }
    public Album Album { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }
    public int Ano { get; set; }
    public bool Disponivel { get; set; }

    public Musica(string nome, Banda artista, Album album)
    {
        Nome = nome;
        Artista = artista;
        Album = album;
        album.AdicionarMusica(this);
    }

    public string DescricaoResumida 
    {
        get
        {
            return $"A musica {Nome} pertence a banda {Artista.Nome} ({Ano})";
        }
    }
    public string DescricaoResumidaLambda => $"A musica {Nome} pertence a banda {Artista.Nome} ({Ano})";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Álbum: {Album.Nome}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
    }
}