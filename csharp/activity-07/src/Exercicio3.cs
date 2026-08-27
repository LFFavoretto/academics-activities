using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios1
{
    public class Exercicio3
    {
        public void Media(double n1, double n2, double n3)
        {
            double media = (n1 + n2 + n3) / 3;
            
            if (media >= 7)
            {
                Console.WriteLine($"Média Final: {media:F1} Aprovado");
            }
            else if (media >= 5 && media < 7)
            {
                Console.WriteLine($"Média Final: {media:F1} Exame");
            }
            else
            {
                Console.WriteLine($"Média Final: {media:F1} Reprovado");
            }
        }
    }
}
