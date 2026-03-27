// See https://aka.ms/new-console-template for more information
using Atividade2;

while (true)
{
    Console.WriteLine("""
        
        Bem vindo ao Resolut 2.0
        [ 1 ] - Exercício 1: Gasto de Combustível
        [ 2 ] - ExercÍcio 2: Intervalo
        [ 3 ] - Exercício 3: Média 2
        [ 4 ] - Desafio: Jogo de Boca
        [ 0 ] - Sair do programa

        Escolha uma opção digitando o número:         
        """);
    var entrada = (Console.ReadLine());
    Console.WriteLine();

    if (!int.TryParse(entrada, out int num) || num < 0 || num > 4)
    {
        Console.WriteLine("Entrada Inválida!!! Digite apenas números entre 0 e 4.");
        Console.WriteLine();
    }

    else if (num == 1 )
    {
        var calculo = new Exercicio1();
        Console.WriteLine("Digite o tempo em horas: ");
        var entradaTempo = Console.ReadLine();
        Console.WriteLine("Digite a velocidade média em km/h");
        var entradaVelocidade = Console.ReadLine();
        
        if (!decimal.TryParse(entradaTempo, out decimal tempo) || !decimal.TryParse(entradaVelocidade, out decimal velocidade) || tempo <= 0 || velocidade <= 0)
        {
            Console.WriteLine("Por favor digite apenas números inteiros e positivos!");
        }
        else
        {
            calculo.Solucao1(velocidade, tempo);
            Console.WriteLine();
        }
    }

    else if (num == 2)
    {
        var intervalo = new Exercicio2();
        Console.WriteLine("Digite um valor real (Ex: 3, 3.0, 3.25): ");
        var entradaValor = Console.ReadLine();

        if (float.TryParse(entradaValor, out float valor))
        {
            intervalo.Solucao2(valor);
        }
        else
        {
            Console.WriteLine("ERRO!!! Digite um valor real válido");
        }
        Console.WriteLine();
    }

    else if (num == 3)
    {
        var media = new Exercicio3();
        Console.WriteLine("Digite a primeira nota: ");
        var entrada1 = Console.ReadLine();
        Console.WriteLine("Digite a segunda nota: ");
        var entrada2 = Console.ReadLine();
        Console.WriteLine("Digite a terceira nota: ");
        var entrada3 = Console.ReadLine();

        if (double.TryParse(entrada1, out double nota1) &&
            double.TryParse(entrada2, out double nota2) &&
            double.TryParse(entrada3, out double nota3))
        {
            nota1 = Math.Round(nota1, 1, MidpointRounding.AwayFromZero);
            nota2 = Math.Round(nota2, 1, MidpointRounding.AwayFromZero);
            nota3 = Math.Round(nota3, 1, MidpointRounding.AwayFromZero);
            media.Solucao3(nota1, nota2, nota3 );
        }
        else
        {
            Console.WriteLine("ERRO!!! Digite uma nota válida");
        }
    }

    else if (num == 4)
    {
        var jogo = new Desafio();
        Console.WriteLine("Digite um número para a partida: ");
        var numero = int.Parse(Console.ReadLine());
        jogo.Solucao4(numero);
    }

    else if (num == 0)
    {
        Console.WriteLine("Obrigado por participar");
        break;
    }
}
