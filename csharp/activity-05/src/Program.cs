// See https://aka.ms/new-console-template for more information
using Atividade4;

var primo = new Primo();
while (true)
{    
    Console.WriteLine("Digite um número inteiro até 200.000: ");
    var entrada = Console.ReadLine();

    if (!int.TryParse(entrada, out int n))
    {
        Console.WriteLine("Número inválido!!!");
    }

    else if (n < 1 || n > 200000)
    {
        Console.WriteLine("Número fora dos limites permitido");
    }

    else
    {
        var resultado = primo.CalcularIntervalo(n);
        foreach (var p in resultado)
        {
            Console.WriteLine(p);
        }
        break;
    }
 
}

