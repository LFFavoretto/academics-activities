using Pagamentos.Models;
using System.Drawing;

var pagamentos = new List<Pagamento>();

while (true)
{
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("""
        1 - Fazer Pagamento
        2 - Listar Pagamento
        3 - Sair 
        """);
    var entrada1 = Console.ReadLine();
    if (entrada1 == null || !int.TryParse(entrada1, out int escolha))
    {
        Console.WriteLine("Por favor escolha uma opção númerica valida");
    }

    else if (escolha == 1)
    {
        Console.WriteLine("Digite o valor do pagamento: ");
        var valor = decimal.Parse(Console.ReadLine());
        Console.WriteLine("""
        Metodos de pagamento
        1 - Dinheiro
        2 - Débito
        3 - Crédito (10% de desconto)       
        Escolha a opção de pagamento: 
        """);
        var entrada2 = Console.ReadLine();

        if (entrada2 == null || !int.TryParse(entrada2, out int opcao))
        {
            Console.WriteLine("Por favor digite 1, 2 ou 0 para continuar");
        }

        else if (opcao == 1)
        {
            var opcao1 = new Pagamento();
            Console.WriteLine("Processando Pagamento...");
            Thread.Sleep(3000);
            Console.WriteLine("Pagamento Aprovado");
            opcao1.Pagar(valor);
            opcao1.MostrarPagamento();
            pagamentos.Add(opcao1);
        }
        else if (opcao == 2)
        {
            var opcao2 = new PagamentoDebito();
            Console.WriteLine("Digite os 4 últimos digitos do cartão:  ");
            var cartao = Console.ReadLine();
            Console.WriteLine("Processando Pagamento...");
            Thread.Sleep(3000);
            Console.WriteLine("Pagamento Aprovado");
            opcao2.FinalCartao = cartao;
            opcao2.Pagar(valor);
            opcao2.MostrarPagamento();
            pagamentos.Add(opcao2);

        }

        else if (opcao == 3)
        {
            var opcao3 = new PagamentoCredito();
            Console.WriteLine("Digite os 4 últimos digitos do cartão:  ");
            var cartao = Console.ReadLine();
            Console.WriteLine("10% de desconto aplicado.");
            Console.WriteLine("Processando Pagamento...");
            Thread.Sleep(3000);
            Console.WriteLine("Pagamento Aprovado");
            opcao3.FinalCartao = cartao;
            opcao3.Pagar(valor);
            opcao3.MostrarPagamento();
            pagamentos.Add(opcao3);

        }
    }
    else if (escolha == 2)
    {
        foreach (var item in pagamentos)
        {
            Console.WriteLine($"{item.ValorRecebido:C}");
        }
    }

    else if (escolha == 3)
    {
        Console.WriteLine("Saindo do programa...");
        Thread.Sleep(2000);
        break;
    }
}