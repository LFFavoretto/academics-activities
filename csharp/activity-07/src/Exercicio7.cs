using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios1
{
    public class Exercicio7
    {
        public void MaiorMenor(Dictionary<string, int> vendas)
        {
            string diaMaior = "";
            string diaMenor = "";
            int maior = 0;
            int menor = 0;
            bool primeiraVenda = true;

            foreach (var venda in vendas)
            {
                if (primeiraVenda)
                {
                    diaMaior = venda.Key;
                    maior = venda.Value;
                    diaMenor = venda.Key;
                    menor = venda.Value;
                    primeiraVenda = false;

                }
                else 
                {
                    if (venda.Value < menor)
                    {
                        diaMenor = venda.Key;
                        menor = venda.Value;
                    }                    
                }
                    if (venda.Value > maior)
                    {
                        diaMaior = venda.Key;
                        maior = venda.Value;
                    }
            }
            Console.WriteLine($"Maior venda: {diaMaior} ({maior})");
            Console.WriteLine($"Menor venda: {diaMenor} ({menor})");
        } 
    }
}
