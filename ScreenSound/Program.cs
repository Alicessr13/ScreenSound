Banda queen = new Banda("Queen");

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

Episodio episodio1 = new Episodio("O Futuro da IA", 1)
{
   Duracao = 3600,
};

Episodio episodio2 = new Episodio("Desenvolvimento Sustentável", 2)
{
    Duracao = 2700,
};

Episodio episodio3 = new Episodio("Inovação em Tecnologia", 3)
{
    Duracao = 3000,
};

episodio1.AdicionarConvidado(convidado);

podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio3);
podcast.AdicionarEpisodio(episodio2);

podcast.ExibirPodcast();


//// Screen Sound
//string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
////List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso"};  
//Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
//bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
//bandasRegistradas.Add("The Beatles", new List<int>());

//void ExibirLogo()
//{
//    Console.WriteLine(@"

//░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
//██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
//╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
//░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
//██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
//╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
//");
//    Console.WriteLine(mensagemDeBoasVindas);
//}

//void ExibirOpcoesDoMenu()
//{
//    ExibirLogo();
//    Console.WriteLine("\nDigite 1 para registrar uma banda");
//    Console.WriteLine("Digite 2 para mostrar todas as bandas");
//    Console.WriteLine("Digite 3 para avaliar uma banda");
//    Console.WriteLine("Digite 4 para exibir a média de uma banda");
//    Console.WriteLine("Digite -1 para sair");

//    Console.Write("\nDigite a sua opção: ");
//    string opcaoEscolhida = Console.ReadLine()!;
//    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

//    switch (opcaoEscolhidaNumerica)
//    {
//        case 1:
//            RegistrarBanda();
//            break;
//        case 2:
//            MostrarBandasRegistradas();
//            break;
//        case 3:
//            AvaliarUmaBanda();
//            break;
//        case 4:
//            ExibirMedia();
//            break;
//        case -1:
//            Console.WriteLine("Tchau tchau :)");
//            break;
//        default:
//            Console.WriteLine("Opção inválida");
//            break;
//    }
//}

//void RegistrarBanda()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Registro das bandas");
//    Console.Write("Digite o nome da banda que deseja registrar: ");
//    string nomeDaBanda = Console.ReadLine()!;
//    bandasRegistradas.Add(nomeDaBanda, new List<int>());
//    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
//    Thread.Sleep(4000);
//    Console.Clear();
//    ExibirOpcoesDoMenu();
//}

//void MostrarBandasRegistradas()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

//    //for (int i = 0; i < listaDasBandas.Count; i++)
//    //{
//    //Console.WriteLine($"Banda: {listaDasBandas[i]}");
//    //}

//    foreach (string banda in bandasRegistradas.Keys)
//    {
//        Console.WriteLine($"Banda: {banda}");
//    }

//    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
//    Console.ReadKey();
//    Console.Clear();
//    ExibirOpcoesDoMenu();

//}

//void ExibirTituloDaOpcao(string titulo)
//{
//    int quantidadeDeLetras = titulo.Length;
//    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
//    Console.WriteLine(asteriscos);
//    Console.WriteLine(titulo);
//    Console.WriteLine(asteriscos + "\n");
//}

//void AvaliarUmaBanda()
//{
//    //digite qual banda deseja avaliar
//    // se a banda exitir no dicionario >> atribuir uma nota
//    // senão, volta ao menu principal

//    Console.Clear();
//    ExibirTituloDaOpcao("Avaliar banda");
//    Console.Write("Digite o nome da banda que deseja avaliar: ");
//    string nomeDaBanda = Console.ReadLine()!;
//    if (bandasRegistradas.ContainsKey(nomeDaBanda))
//    {
//        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
//        int nota = int.Parse(Console.ReadLine()!);
//        bandasRegistradas[nomeDaBanda].Add(nota);
//        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
//        Thread.Sleep(2000);
//        Console.Clear();
//        ExibirOpcoesDoMenu();
//    }
//    else
//    {
//        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
//        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ExibirOpcoesDoMenu();
//    }

//}

//void ExibirMedia()
//{
//    Console.Clear();
//    ExibirTituloDaOpcao("Exibir média da banda");
//    Console.Write("Digite o nome da banda que deseja exibir a média: ");
//    string nomeDaBanda = Console.ReadLine()!;
//    if (bandasRegistradas.ContainsKey(nomeDaBanda))
//    {
//        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
//        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
//        Console.WriteLine("Digite uma tecla para votar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ExibirOpcoesDoMenu();

//    }
//    else
//    {
//        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
//        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
//        Console.ReadKey();
//        Console.Clear();
//        ExibirOpcoesDoMenu();
//    }
//}


//ExibirOpcoesDoMenu();

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