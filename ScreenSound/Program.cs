using ScreenSound;
using ScreenSound.Models;
using static ScreenSound.Avaliacao; // Use 'using static' for the Avaliacao type instead of 'using namespace'
using ScreenSound.Menus;

internal class Program
{
    private static void Main(string[] args)
    {
        Banda queen = new Banda("Queen");
        Banda linkinPark = new("Linkin Park");

        Album albumDoQueen = new Album("A Night at the Opera", queen);


        Musica musica1 = new Musica("Bohemian Rhapsody", queen, albumDoQueen)
        {
            Genero = "Rock",
            Duracao = 354,
            Ano = 1975,
            Disponivel = true
        };
        //Console.WriteLine(musica1.DescricaoResumida);

        //Musica musica2 = new Musica();
        //musica2.Nome = "To Love You More";
        //musica2.Artista = "Celine Dion";
        //musica2.Album = "Falling Into You";
        //musica2.Genero = "Pop";
        //musica2.Duracao = 240;
        //musica2.Ano = 1996;
        //musica2.Disponivel = false;

        //musica1.ExibirFichaTecnica();
        //Console.WriteLine();
        //musica2.ExibirFichaTecnica();


        Musica musica2 = new Musica("Love of My Life", queen, albumDoQueen);
        musica2.Genero = "Rock";
        musica2.Duracao = 220;
        musica2.Ano = 1975;
        musica2.Disponivel = true;

        //albumDoQueen.AdicionarMusica(musica1);
        //albumDoQueen.AdicionarMusica(musica2);

        //albumDoQueen.ExibirMusicas();


        //queen.AdicionarAlbum(albumDoQueen);
        //Console.WriteLine();
        //queen.ExibirDiscografia();

        Convidado convidado = new Convidado("Carlo", new DateOnly(1995, 6, 12), "Italiano");

        Podcast podcast = new Podcast("Tech Talks", "Discussões sobre tecnologia e inovação");

        Episodio episodio1 = new Episodio("O Futuro da IA", 1, 3600);

        Episodio episodio2 = new Episodio("Desenvolvimento Sustentável", 2, 2700);

        Episodio episodio3 = new Episodio("Inovação em Tecnologia", 3, 3000);

        episodio1.AdicionarConvidado(convidado);

        podcast.AdicionarEpisodio(episodio1);
        podcast.AdicionarEpisodio(episodio3);
        podcast.AdicionarEpisodio(episodio2);

        //podcast.ExibirPodcast();



        Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, Banda>();

        queen.AdicionarNota(new Avaliacao(10));
        queen.AdicionarNota(new Avaliacao(6));
        queen.AdicionarNota(new Avaliacao(4));

        bandasRegistradas.Add("Queen", queen);
        bandasRegistradas.Add("Linkin Park", linkinPark);

        void ExibirLogo()
        {
            Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
            Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
        }

        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    MenuRegistrarBanda menuRegistrarBanda = new MenuRegistrarBanda();
                    menuRegistrarBanda.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 2:
                    MenuRegistrarAlbum menuRegistrarAlbum = new MenuRegistrarAlbum();
                    menuRegistrarAlbum.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 3:
                    MenuMostrarBandasRegistradas menuMostrarBandasRegistradas = new MenuMostrarBandasRegistradas();
                    menuMostrarBandasRegistradas.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 4:
                    MenuAvaliarBanda menuAvaliarBanda = new MenuAvaliarBanda();
                    menuAvaliarBanda.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 5:
                    MenuExibirDetalhes menuExibirDetalhes = new MenuExibirDetalhes();
                    menuExibirDetalhes.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case -1:
                    Console.WriteLine("Tchau tchau :)");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        ExibirOpcoesDoMenu();
    }
}

//string nome = "Alice";
//string sobrenome = "Stephanie";

//Console.WriteLine(nome+" "+sobrenome);

//Random random = new Random();

//int numeroAleatorio = random.Next(1, 100);
//Console.WriteLine(numeroAleatorio);
//Console.Write("\nEscolha um número de 1 a 100: ");
//string stringEscolhida = Console.ReadLine();
//int numeroEscolhido = int.Parse(stringEscolhida);
//while(numeroAleatorio != numeroEscolhido)
//{
//    Console.Write("\nNúmero incorreto escolha outro número: ");
//    stringEscolhida = Console.ReadLine();
//    numeroEscolhido = int.Parse(stringEscolhida);
//}
//Console.WriteLine("\nVocê acertou o número!");

//Dictionary<string,List<int>> notaAluno = new Dictionary<string, List<int>>();
//notaAluno.Add("Alice", new List<int> { 10, 9, 8 });
//int soma = 0;
//int media = 0;
//foreach (var aluno in notaAluno)
//{
//    Console.WriteLine($"O aluno {aluno.Key} tem as notas: ");
//    foreach (var nota in aluno.Value)
//    {
//        soma += nota;
//    }
//    media = soma / aluno.Value.Count;
//}

//Console.WriteLine($"A media das notas do aluno é: {media}");

//Dictionary<string, Dictionary<string, bool>> perguntas = new Dictionary<string, Dictionary<string, bool>>();
//perguntas.Add("Qual é a capital da França?", new Dictionary<string, bool>
//{
//    { "Paris", true },
//    { "Londres", false },
//    { "Berlim", false },
//    { "Madri", false }
//});