int option = 0;
Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>();
bands.Add("Banda 01", new List<int>() { 10, 9, 8 });
bands.Add("Banda 02", new List<int>());
//List<string> bandList = new List<string>() {"Banda 01", "Banda 02"};

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
            RankingBands();
            break;
        case 4:
            ShowRankAvarage();
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

void SetTitle (string title)
{
    char caracter = '#';
    int extraSpaces = 4;
    string decoration = string.Empty.PadRight(title.Length + extraSpaces, caracter);

    Console.Clear();
    Console.WriteLine(decoration);
    Console.WriteLine($"{caracter} {title} {caracter}");
    Console.WriteLine(decoration);
    Console.WriteLine("\n");
}

void RegisterBand()
{    
    SetTitle("Registro de Bandas");
    Console.Write("Digite o nome da banda: ");
    
    string band = Console.ReadLine()!;
    bands.Add(band, new List<int>());

    Console.WriteLine($"A banda {band} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
}

void ListBand()
{
    SetTitle("Lista de Bandas");

    foreach (string band in bands.Keys)
    {
        Console.WriteLine($"{band}");
    }

    Console.Write("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}


void RankingBands ()
{   
    SetTitle("Avaliar Bandas");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string bandName = Console.ReadLine()!;

    if (bands.ContainsKey(bandName))
    {
        Console.Write("Digite uma nota entre 0 a 10: ");
        int rank = int.Parse(Console.ReadLine()!);

        bands[bandName].Add(rank);
        Console.WriteLine("Nota registrada com sucesso!");
    }
    else
    {
        Console.WriteLine($"A banda {bandName} não foi encontrada!");
    }

    Console.Write("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}

void ShowRankAvarage()
{
    SetTitle("Média de Avaliação das Bandas");

    Console.Write("Digite o nome da banda que deseja visualizar: ");
    string bandName = Console.ReadLine()!;

    if (bands.ContainsKey(bandName))
    {        
        if (bands[bandName].Count == 0) 
        {
            Console.WriteLine($"A banda {bandName} não possui notas cadastradas");
        } 
        else
        {
            Console.WriteLine($"Banda {bandName}: \n");
            
            foreach (int rank in bands[bandName])
            {
                Console.WriteLine($"Nota: {rank}");
            }

            List<int> rankList = bands[bandName];
            Console.WriteLine($"\nMédia de Notas: {rankList.Average()}");
        }
    }
    else
    {
        Console.WriteLine($"A banda {bandName} não foi encontrada!");
    }

    Console.Write("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}