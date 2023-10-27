
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasbandas = new List<string> {"Nike", "JBL", "Yakusa"};


void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as banda");
    Console.WriteLine("Digite 3 para para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite -1 para registrar uma banda");

    Console.Write("\nDigite a sua opção: ");
    // Console.ReadLine();

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            RegistrarBanda();
            break;
        case 4:
            RegistrarBanda();
            break;
        case -1:
            RegistrarBanda();
            break;
        default:
            RegistrarBanda();
            break;
    }

    void RegistrarBanda()
    {
        Console.Clear();
        Console.WriteLine("******************");
        Console.WriteLine("Registro de bandas");
        Console.WriteLine("******************************");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Console.WriteLine($"A banda: '{nomeDaBanda}' foi registrada com sucesso!");
        listaDasbandas.Add(nomeDaBanda);
        Thread.Sleep(2000);
        Console.Clear(); // Limpar a banda registrada após a mensagem
        ExibirOpcoesDoMenu();
        //ExibirLogo();
    }
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("******************************");
    Console.WriteLine("Exibindo o Registro de bandas");
    Console.WriteLine("******************************\n");
    /* 
     for (int i = 0; i < listaDasbandas.Count; i++)
    {
        Console.WriteLine($"Banda:  {listaDasbandas[i]}");
    }
    */

    foreach (string banda in listaDasbandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu prinicipal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
// ExibirLogo();
ExibirOpcoesDoMenu();