using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    public class Desafio
    {
        public void Solucao4 (int n)
        {
            if (n % 3 == 0)
            {
                Console.WriteLine(0);
            }
            else if (n % 3 == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2);
            }
        }
    }
}
