using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    public class Exercicio1
    {
        public int Solucao1 (int t1, int t2, int t3) 
        {
            var andar1 = (t2 * 2) + (t3 * 4);
            var andar2 = (t1 * 2) + (t3 * 2);
            var andar3 = (t2 * 2) + (t1 * 4);
            var resultado = Math.Min(andar1, Math.Min(andar2, andar3));
            Console.WriteLine($"Menor tempo: {resultado} minutos.");
            return resultado;

        }
    }
}
