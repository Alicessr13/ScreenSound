public class Convidado
{
    public string Nome { get; }
    public DateOnly Nascimento { get; set; }
    public string Nacionalidade { get; set; }
    public Convidado(string nome, DateOnly nascimento, string nacionalidade)
    {
        Nome = nome;
        Nascimento = nascimento;
        Nacionalidade = nacionalidade;
    }
}