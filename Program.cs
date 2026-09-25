// Scream Sound

string mensagemDeBoasVindas = "Boas vindas ao Scream Sound";

Dictionary<string, List<int>> bandasRegistradas =
    new Dictionary<string, List<int>>();

bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine(mensagemDeBoasVindas);
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine() ?? "";

    if (string.IsNullOrWhiteSpace(nomeDaBanda))
    {
        Console.WriteLine("O nome da banda não pode ser vazio.");
        Console.ReadKey();
        return;
    }

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"A banda {nomeDaBanda} já está registrada.");
    }
    else
    {
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Console.WriteLine($"Banda {nomeDaBanda} foi registrada com sucesso!");
    }

    Thread.Sleep(2000);
}

void ListarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Listando as bandas registradas");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine() ?? "";

    // Procura ignorando maiúsculas/minúsculas
    string? bandaEncontrada = bandasRegistradas.Keys
        .FirstOrDefault(b => b.Equals(nomeDaBanda, StringComparison.OrdinalIgnoreCase));

    if (bandaEncontrada == null)
    {
        Console.WriteLine($"\nBanda {nomeDaBanda} não encontrada.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        return;
    }

    Console.Write($"Qual a nota fornecida para a banda {bandaEncontrada}: ");

    if (int.TryParse(Console.ReadLine(), out int nota))
    {
        bandasRegistradas[bandaEncontrada].Add(nota);

        Console.WriteLine(
            $"\nNota {nota} registrada com sucesso para a banda {bandaEncontrada}!"
        );
    }
    else
    {
        Console.WriteLine("\nDigite uma nota válida.");
    }

    Thread.Sleep(2000);
}

void ExibirMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média da Banda");

    Console.Write("Digite o nome da banda que deseja ver a média das avaliações: ");
    string nomeDaBanda = Console.ReadLine() ?? "";

    string? bandaEncontrada = bandasRegistradas.Keys
        .FirstOrDefault(b => b.Equals(nomeDaBanda, StringComparison.OrdinalIgnoreCase));

    if (bandaEncontrada == null)
    {
        Console.WriteLine($"\nBanda {nomeDaBanda} não encontrada.");
    }
    else
    {
        List<int> notasDaBanda = bandasRegistradas[bandaEncontrada];

        if (notasDaBanda.Count == 0)
        {
            Console.WriteLine($"\nA banda {bandaEncontrada} ainda não possui avaliações.");
        }
        else
        {
            Console.WriteLine(
                $"\nA média da banda {bandaEncontrada} é: {notasDaBanda.Average():0.00}"
            );
        }
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

void ExibirOpcoesDoMenu()
{
    while (true)
    {
        Console.Clear();

        Console.WriteLine("Digite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para mostrar todas as bandas");
        Console.WriteLine("Digite 3 para avaliar uma banda");
        Console.WriteLine("Digite 4 para exibir a média de uma banda");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite a sua opção: ");

        string opcaoEscolhida = Console.ReadLine() ?? "";

        if (!int.TryParse(opcaoEscolhida, out int opcaoEscolhidaNumerica))
        {
            Console.WriteLine("\nDigite uma opção válida.");
            Thread.Sleep(1500);
            continue;
        }

        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                RegistrarBanda();
                break;

            case 2:
                ListarBandas();
                break;

            case 3:
                AvaliarBanda();
                break;

            case 4:
                ExibirMediaDaBanda();
                break;

            case -1:
                Console.WriteLine("\nVocê escolheu sair.");
                return;

            default:
                Console.WriteLine("\nOpção inválida.");
                Thread.Sleep(1500);
                break;
        }
    }
}

ExibirLogo();
ExibirOpcoesDoMenu();