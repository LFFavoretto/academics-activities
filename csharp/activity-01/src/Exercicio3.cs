using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    public class Exercicio3
    {
        public void Solucao3(int n) 
        {
            var t1 = 0;
            var t2 = 1;
            Console.Write($"{t1}" + " " + $"{t2}" + " ");
            var cont = 3;
            while (cont <= n) {
                var t3 = t1 + t2;
                Console.Write($"{t3}" + " ");
                t1 = t2;
                t2 = t3;
                cont++;                
            }
            Console.WriteLine("FIM.");
        }
    }
}
