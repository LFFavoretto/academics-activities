using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    public class Exercicio3
    {
        public double Solucao3(double a, double b, double c)
        {
            var n1 = a * 0.2;
            var n2 = b * 0.3;
            var n3 = c * 0.5;
            var m = (n1 + n2 +  n3);
            Console.WriteLine($"Media: {m:F1}");
            return m;
        }
    }
}
