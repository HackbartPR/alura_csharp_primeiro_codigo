int option = 0;
List<string> bandList = new List<string>() {"Banda 01", "Banda 02"};

do
{
    option = ShowMenu();

    switch (option)
    {
        case 0:
            Console.WriteLine("Até mais! ");
            Thread.Sleep(2000);
            break;
        case 1:
            RegisterBand();
            break;
        case 2:
            ListBand();
            break;
        case 3:
            Console.WriteLine("Opcao " + option);
            break;
        case 4:
            Console.WriteLine("Opcao " + option);
            break;
        default:
            Console.WriteLine("Opcao Inválida");
            break;
    }

} while (option != 0);

void ShowGreetings()
{
    Console.WriteLine("################");
    Console.WriteLine("# SCREEN SOUND #");
    Console.WriteLine("################");
}

int ShowMenu()
{
    ShowGreetings();

    Console.WriteLine("\n");
    Console.WriteLine("1 - Registrar Banda");
    Console.WriteLine("2 - Listar Bandas");
    Console.WriteLine("3 - Avaliar uma Banda");
    Console.WriteLine("4 - Média de Avaliação");
    Console.WriteLine("0 - Sair");

    Console.Write("\nDigite uma opção: ");
    int option = int.Parse(Console.ReadLine()!);

    return option;

}

void RegisterBand()
{
    Console.Clear();
    Console.Write("Registro de Bandas: ");
    Console.Write("Digite o nome da banda: ");
    
    string band = Console.ReadLine()!;
    bandList.Add(band);

    Console.WriteLine($"A banda {band} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
}

void ListBand()
{
    Console.Clear();
    Console.Write("Lista de Bandas: \n");

    foreach (string band in bandList)
    {
        Console.WriteLine($"{band}");
    }

    Console.Write("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}
