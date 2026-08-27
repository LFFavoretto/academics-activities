using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios1
{
    public class Exercicio4
    {
        public void Tabuada(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                int r = i * n;
                Console.WriteLine($"{i} X {n} = {r}");
            }
        }
    }
}
