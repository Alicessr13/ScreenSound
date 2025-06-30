namespace ScreenSound;
internal class Avaliacao
{
    public int Nota { get; private set; }

    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public static Avaliacao Parse(string input)//static, pode chamar o metodo diretamente sem instanciar a classe Avaliacao
    {
        int nota = int.Parse(input);
        if (nota >= 0 && nota <= 10)
        {
            return new Avaliacao(nota);
        }
        else
        {
            throw new ArgumentException("Nota inválida. Deve ser um número entre 0 e 10.");
        }
    }
}
