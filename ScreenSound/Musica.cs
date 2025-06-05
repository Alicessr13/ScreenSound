class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public string Album { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }
    public int Ano { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida 
    {
        get
        {
            return $"A musica {Nome} pertence a banda {Artista} ({Ano})";
        }
    }
    public string DescricaoResumidaLambda => $"A musica {Nome} pertence a banda {Artista} ({Ano})";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Álbum: {Album}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
    }
}