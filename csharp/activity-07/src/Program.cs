using ListaExercicios1;

while (true)
{
    Console.WriteLine("""
        Escolha um exercicio:
        1 - Classificador de idade
        2 - Conversor de temperatura (F° e C°)
        3 - Situação do aluno
        4 - Tabuada com laço
        5 - Estatísticas de uma lista de notas
        6 - Filtrar números pares
        7 - Maior e menor venda da semana
        8 - Gerenciador de tarefas
        0 - Sair do programa
        """);
    var entrada = Console.ReadLine();
    Console.Clear();

    if (!int.TryParse(entrada, out int opcao) || opcao < 0 || opcao > 8)
    {
        Console.WriteLine("Entrada Inválida!!!!");
        Console.WriteLine();
    }

    else if (opcao == 1)
    {
        var verificar = new Exercicio1();
        Console.WriteLine("Digite sua idade: ");
        var idade = int.Parse(Console.ReadLine());
        Console.WriteLine();
        verificar.ClassificarIdade(idade);
        Console.WriteLine();
    }
    else if (opcao == 2)
    {
        var conversao = new Exercicio2();
        Console.WriteLine("Digite a temperatura em Fahrenheit (°F): ");
        var temp = double.Parse(Console.ReadLine());
        Console.WriteLine();
        conversao.Converter(temp);
        Console.WriteLine();
    }
    else if (opcao == 3)
    {
        var situacao = new Exercicio3();
        Console.WriteLine("Digite as 3 notas separadas por espaço: ");
        string[] entradas = Console.ReadLine().Split();
        double n1 = double.Parse(entradas[0]);
        double n2 = double.Parse(entradas[1]);
        double n3 = double.Parse(entradas[2]);
        Console.WriteLine();
        situacao.Media(n1, n2, n3);
        Console.WriteLine();

    }
    else if (opcao == 4)
    {
        var conta = new Exercicio4();
        Console.WriteLine("Digite o valor para mostrar sua tabuada: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        conta.Tabuada(n);
        Console.WriteLine();
    }
    else if (opcao == 5)
    {
        List<double> notas = new List<double> { 7.5, 9.0, 8.5, 6.0, 8.5 };

        new Exercicio5().EstatisticasNotas(notas);
        Console.WriteLine();

    }
    else if(opcao == 6)
    {
        List<int> numeros = new List<int> { 3, 8, 15, 22, 9, 40, 7 };
        var resultado = new Exercicio6().VerificarPares(numeros);

        Console.WriteLine($"Pares: {string.Join(", ", resultado.pares)}");
        Console.WriteLine($"Ímpares: {string.Join(", ", resultado.impares)}");
        Console.WriteLine();
    }
    else if(opcao == 7)
    {
        Dictionary<string, int> vendas = new Dictionary<string, int> {{ "seg", 3200 }, { "ter", 950 }, { "qua", 1800 }, { "qui", 700 }, { "sex", 2100 }};
        new Exercicio7().MaiorMenor(vendas);
        Console.WriteLine();

    }
    else if(opcao == 8)
    {
        var gerenciador = new Exercicio8();
        while (true)
        {
            Console.WriteLine("""
                Escolha uma opção
                1 - Adicionar tarefa
                2 - Remover tarefa
                3 - Procurar tarefa
                4 - Mostrar lista de tarefas
                0 - Sair
                """);
            var numero = Console.ReadLine();
            Console.Clear();

            if (!int.TryParse(numero, out int escolha) || escolha < 0 || escolha > 4)
            {
                Console.WriteLine("Entrada Inválida!!!!");
            }
            else if (escolha == 1)
            {
                Console.WriteLine("Digite a tarefa para adicionar: ");
                string tarefa = Console.ReadLine();
                Console.WriteLine();
                gerenciador.Verificar(tarefa);

                if (!gerenciador.Verificar(tarefa))
                {
                    gerenciador.Adicionar(tarefa);
                    Console.WriteLine("Tarefa adicionada com sucesso");
                }
                else
                {
                    Console.WriteLine("Tarefa já está na lista.");
                }
                Console.WriteLine();
            }
            else if (escolha == 2)
            {
                Console.WriteLine($"Quantidade de tarefas na lista: {gerenciador.Contar()}\n");
                Console.WriteLine("Digite a tarefa a ser removida: ");
                string tarefa = Console.ReadLine();
                Console.WriteLine();

                gerenciador.Verificar(tarefa);
                if (gerenciador.Verificar(tarefa))
                {
                    gerenciador.Remover(tarefa);
                    Console.WriteLine($"Tarefa {tarefa} removida com sucesso");
                }
                else
                {
                    Console.WriteLine("Tarefa não encontrada!");
                }
                Console.WriteLine($"Quantidade de tarefas na lista: {gerenciador.Contar()}");
                Console.WriteLine();
            }
            else if (escolha == 3)
            {
                Console.WriteLine("Digite a tarefa que está procurando: \n");
                string tarefa = Console.ReadLine();
                Console.WriteLine();

                gerenciador.Verificar(tarefa);

                if (gerenciador.Verificar(tarefa))
                {
                    Console.WriteLine($"A tarefa {tarefa} está na lista.");
                }
                else
                {
                    Console.WriteLine("Tarefa não encontrada");
                }
                Console.WriteLine();
            }
            else if (escolha == 4)
            {
                gerenciador.Listar();
                Console.WriteLine();
            }
            else if (escolha == 0)
            {
                break;
            }
        }
    }
    else if (opcao == 0)
    {
        break;
    }
}


