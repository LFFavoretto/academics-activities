using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos.Models
{
    public class Pagamento
    {
        public decimal Valor { get; set; }
        public decimal ValorRecebido { get; protected set; }

        public virtual void Pagar(decimal valorPagamento)
        {
            ValorRecebido = valorPagamento;
            Valor = valorPagamento;
        }
        public virtual void MostrarPagamento()
        {
            Console.WriteLine($"Valor Total: {Valor:C}");
            Console.WriteLine($"Valor Recebido: {ValorRecebido:C}");            
        }
    }
}
