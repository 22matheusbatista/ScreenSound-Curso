
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

void exibirMensagemDeBoasVindas (){

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
        case 1: Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 2: Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 3: Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1: Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("Opção Inválida!");
            break;
    }
}
exibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();