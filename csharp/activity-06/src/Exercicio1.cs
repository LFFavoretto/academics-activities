using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    public class Exercicio1
    {
        public int Calculo_Saldo (int s, int n)
        {
           
            var contador = 0;            
            int saldo = n;

            int menor_saldo = saldo;

            while (contador < s)
            {
                Console.WriteLine("Digite o saque (valor negativo) ou depósito:");
                int d = int.Parse(Console.ReadLine());
                saldo += d;                
                
                if (saldo < menor_saldo)
                {
                    menor_saldo = saldo;
                }

                contador++;
            }

            Console.WriteLine($"Menor saldo no periodo: {menor_saldo}");
            return menor_saldo;

                
        }
    }
}
