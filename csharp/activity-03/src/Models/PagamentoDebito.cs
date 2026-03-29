using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos.Models
{
    internal class PagamentoDebito : Pagamento
    {
        public string FinalCartao {  get; set; }

        //public override void Pagar(decimal valorPagamento)
        //{
        //    base.Pagar(valorPagamento);
        //} *NÃO PRECISA CHAMAR ESSE METODO SE ELE NÃO TIVER ALTERAÇÃO E SE NA CLASSE PRINCIPAL ELE ESTÁ COMO PUBLIC*

        public override void MostrarPagamento()
        {
            base.MostrarPagamento();
            Console.WriteLine($"Final do cartão: {FinalCartao}");
        }
    }
}
