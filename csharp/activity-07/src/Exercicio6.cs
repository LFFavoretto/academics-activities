using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios1
{
    public class Exercicio6
    {
        public (List<int> pares, List<int> impares) VerificarPares(List<int> numeros)
        {
            var pares = numeros.Where(n => n % 2 == 0).ToList();
            var impares = numeros.Where(n => n % 2 != 0).ToList();
            return (pares, impares);         
        }
    }
}
