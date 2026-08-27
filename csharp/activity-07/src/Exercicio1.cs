using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios1
{
    public class Exercicio1
    {
        public void ClassificarIdade(int idade)
        {
            if (idade < 0)
            {
                Console.WriteLine("Idade Inválida!!!!");
            }            
            else if (idade >= 0 && idade <= 12)
            {
                Console.WriteLine("Você é uma criança.");
            }
            else if (idade > 12 && idade <= 17)
            {
                Console.WriteLine("Você é um adolescente.");
            }
            else if (idade > 17 && idade <= 59)
            {
                Console.WriteLine("Você é um adulto");
            }
            else
            {
                Console.WriteLine("Você é um idoso.");
            }
        }
    }
}
