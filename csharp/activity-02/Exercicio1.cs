using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    public class Exercicio1
    {
        public decimal Solucao1 (decimal v, decimal t) 
        {
            var consumo = 12;
            var distancia = v * t;
            var combustivel = distancia / consumo;            
            Console.WriteLine($"Quantidade de litros necessario: {combustivel:F3} litros");
            return combustivel;
        }
    
    }
}
