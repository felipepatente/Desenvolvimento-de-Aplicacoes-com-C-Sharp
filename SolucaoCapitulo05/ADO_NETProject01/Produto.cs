using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NETProject01
{
    public class Produto
    {
        public long? Id { get; set; }
        public string Descricao { get; set; }
        public double PrecoDeCusto { get; set; }
        public double PrecoDeVenda { get; set; }
        public double Estoque { get; set; }

        public Produto()
        {
            this.Id = null;
        }

        public Produto(string descricao)
        {
            this.Descricao = descricao;
        }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
