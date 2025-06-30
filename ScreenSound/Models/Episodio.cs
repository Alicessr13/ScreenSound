namespace ScreenSound.Models;

internal class Episodio
{
    public string Titulo { get; }
    public int Duracao { get; }
    public int Ordem { get; }
    public List<Convidado> Convidados { get; set; }

    public string Resumo
    {
        get
        {
            return $"Episódio: {Titulo}, Duração: {Duracao} minutos, Ordem: {Ordem}, {ExibirConvidado()}";
        }
    }

    public Episodio(string titulo, int ordem, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }

    public void AdicionarConvidado(Convidado convidado)
    {
        if (Convidados == null)
        {
            Convidados = new List<Convidado>();
        }
        Convidados.Add(convidado);
    }

    public string ExibirConvidado()
    {
        return Convidados != null && Convidados.Count > 0
            ? $"Convidados: {string.Join(", ", Convidados.Select(c => c.Nome))}"
            : "Nenhum convidado";
    }
}