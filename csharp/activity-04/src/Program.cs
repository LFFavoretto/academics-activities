// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

Console.WriteLine("Quantidade de numeros a serem digitados: ");
var n = int.Parse(Console.ReadLine());
List<int> lista = new List<int>();

while (n > 0)
{
    Console.WriteLine("Digite um número inteiro: ");
    var numero = int.Parse(Console.ReadLine());
    lista.Add(numero);
    n--;
}

List<int> contados = new List<int>();

foreach (var item in lista)
{
    if (!contados.Contains(item))
    {
        int contar = 0;

        foreach (var i in lista)
        {
            if (i == item)
            {
                contar++;
            }
        }
        Console.WriteLine($"{item}: {contar}");
        contados.Add(item);
    } 
}

//var contagem = lista.GroupBy(i => i);

//foreach (var numero in contagem)
//{
//    Console.WriteLine($"{numero.Key}: {numero.Count()}");
//}
