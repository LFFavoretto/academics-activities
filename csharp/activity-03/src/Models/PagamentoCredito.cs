using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos.Models
{
    internal class PagamentoCredito : Pagamento
    {
        public string FinalCartao {  get; set; }

        public override void Pagar(decimal valorPagamento)
        {
            base.Pagar(valorPagamento);
            ValorRecebido = valorPagamento * 0.9m;
        }

        public override void MostrarPagamento()
        {
            base.MostrarPagamento();
            Console.WriteLine($"Final do cartão: {FinalCartao}");
        }
    }
}
