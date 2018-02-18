using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NETProject01
{
    public class ProdutoNotaEntrada
    {
        public long? Id { get; set; } 
        public Produto ProdutoNota { get; set; }
        public double PrecoCustoCompra { get; set; }
        public double QuantidadeComprada { get; set; }

        public ProdutoNotaEntrada()
        {
            this.Id = null;
        }
    }
}
