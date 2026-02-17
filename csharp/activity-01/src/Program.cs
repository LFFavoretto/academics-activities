using Atividade_1;
using System.ComponentModel.Design;

while (true)
{
    Console.WriteLine("""
        Bem vindo ao Resolut.
        [ 1 ] - Solução do exercício 1.
        [ 2 ] - Solução do exercício 2.
        [ 3 ] - Solução do exercício 3.
        [ 0 ] - Sair do programa.
        """);

    var opcao = int.Parse(Console.ReadLine());
    if (opcao > 3 || opcao < 0)
    {
        Console.WriteLine("Opção Invalida!");
    }

    else if (opcao == 1)
    {
        var atividade1 = new Exercicio1();
        Console.WriteLine("Digite a quantidade de funcionarios no primeiro andar");
        var a1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de funcionarios no segundo andar");
        var a2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de funcionarios no terceiro andar");
        var a3 = int.Parse(Console.ReadLine());
        atividade1.Solucao1(a1, a2, a3);
    }

    else if (opcao == 2)
    {
        var atividade2 = new Exercicio2();
        Console.WriteLine("Digite o valor: ");
        var t = int.Parse(Console.ReadLine());
        atividade2.Solucao2(t);
    }

    else if (opcao == 3) 
    {
        var atividade3 = new Exercicio3();
        Console.WriteLine("Quantos numeros você quer mostrar: ");
        var t = int.Parse(Console.ReadLine());
        atividade3.Solucao3(t);
    }

    else 
    {
        Console.WriteLine("Programa Finalizado");
        break;
    }

} 

    