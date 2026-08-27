using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios1
{
    public class Exercicio5
    {
        public void EstatisticasNotas(List<double> notas)
        {
            double soma = 0;
            double media = 0;
            double maior = notas[0]; 
            double menor = notas[0];

            foreach (double nota in notas)
            {
                soma += nota;
                if (nota > maior)
                {
                    maior = nota;
                }
                if (nota < menor)
                {
                    menor = nota;
                }
            }

            media = soma / notas.Count();

            Console.WriteLine($"Soma das notas: {soma:F1}");
            Console.WriteLine($"Média das notas: {media:F1}");
            Console.WriteLine($"Maior nota: {maior:F1}");
            Console.WriteLine($"Menor nota: {menor:F1}");
        }
    }
}
