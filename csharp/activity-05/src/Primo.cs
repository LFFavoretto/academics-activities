using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    public class Primo    {
        
        // Metodo que verifica se um número é primo
        private bool EhPrimo(int n)
        {
            // Cria uma variavel para contar os divisores
            int divisores = 0;

            // Percorre os numeros de 2 até n para verificar divisibilidade
            for (int i = 1; i <= n; i++)
            {
                // Verifica se n é divisivel por (resto da divisão igual a 0)
                if (n % i == 0)
                {
                    // Se tiver resto 0, conta o divisor
                    divisores++;
                }
            }
            // Retorna true se encontrou exatamente dois divisores no intervalo testado
            return divisores == 2;
        }
        public List<int> CalcularIntervalo (int numero)
        {
            // Cria uma lista vazia 
            var primos = new List<int>();

            // Percorre todos os numeros de 2 até numero
            for (var i = 2; i <= numero; i++)
            {
                // Verifica se é primo
                if (EhPrimo(i))
                {
                    // Se for primo adiciona na lista
                    primos.Add(i);
                }                
            }
            // Retorna a lista
            return primos;
        }
    }
}
