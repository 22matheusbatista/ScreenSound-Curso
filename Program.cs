
using System.Linq;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//st<string> listaDasbandas = new List<string> {"Nike", "JBL", "Yakusa"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin park", new List<int> { 10, 8, 9 });
bandasRegistradas.Add("Calipyso", new List<int>());

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
            avaliarUmabanda();
            break;
        case 4:
            exibirMedia();
            break;
        default:
            Console.WriteLine("Saindo ... ");
            break;
    }

    void RegistrarBanda()
    {
        Console.Clear();
        ExibirTituloDasOpcoes("Exibindo todas as bandas registradas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Console.WriteLine($"A banda: '{nomeDaBanda}' foi registrada com sucesso!");
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Thread.Sleep(2000);
        Console.Clear(); // Limpar a banda registrada após a mensagem
        ExibirOpcoesDoMenu();
        //ExibirLogo();
    }
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDasOpcoes("Exibindo todas as bandas registradas");
    /* 
     for (int i = 0; i < listaDasbandas.Count; i++)
    {
        Console.WriteLine($"Banda:  {listaDasbandas[i]}");
    }
    */

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu prinicipal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void ExibirTituloDasOpcoes(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");  
};
void avaliarUmabanda()
{
    Console.Clear();
    ExibirTituloDasOpcoes("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: \n");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual o nome que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(5000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.Write("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
                

}
void exibirMedia()
    {
    Console.Clear();
    ExibirTituloDasOpcoes("Média das Bandas");
    Console.Write("Digite o nome da banda para visualizar a média: ");
    string nomeDaBanda = (Console.ReadLine()!);
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        //double nomeDabanda = int.Parse((Console.ReadLine())!);
        double media = bandasRegistradas[nomeDaBanda].Average();
        Console.WriteLine($"A média da banda {nomeDaBanda} é: " + media);
        Thread.Sleep(2000);
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
        
    };

ExibirOpcoesDoMenu();