// See https://aka.ms/new-console-template for more information
using Atividade5;

while (true) {
    Console.WriteLine("""
        Bem vindo ao Resolut 3.0.
        [ 1 ] - Exercicio 1: Saldo do Vovô
        [ 2 ] - Exercicio 2: Blobs
        [ 0 ] - Sair do programa.
        """);

    var entrada = Console.ReadLine();

    if (!int.TryParse(entrada, out int opcao) || opcao < 0 || opcao > 2)
    {
        Console.WriteLine("Entrada inválida!!! Tente novamente.");
    }

    else if (opcao == 1)
    {
        var conta_bancaria = new Exercicio1();
        Console.WriteLine("Digite dois números inteiros separados por espaço");
        var dados = Console.ReadLine().Split(' ');

        int dias = int.Parse(dados[0]);
        int saldo = int.Parse(dados[1]);

        conta_bancaria.Calculo_Saldo(dias, saldo);

        Console.WriteLine("");
    }

    else if (opcao == 2)
    {
        var comida = new Exercicio2();
        Console.WriteLine("Digite quantos testes quer fazer: ");
        int testes = int.Parse(Console.ReadLine());
        comida.Calculo_Dias(testes);
    }

    else if (opcao == 0)
    {
        break;
    }
}
