using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    public class Exercicio2
    {
        public void Calculo_Dias(int n)
        {
            var contador = 0;
            while (contador < n)
            {
                Console.WriteLine("Digite a quantidade de comida: ");
                float qtd = float.Parse(Console.ReadLine());

                var dias = 0;
                while (qtd > 1)
                {                    
                    qtd = qtd / 2;
                    dias++;
                }
                Console.WriteLine($"{dias} dias.");                
                contador++;
            }            
        }
    }       
}
