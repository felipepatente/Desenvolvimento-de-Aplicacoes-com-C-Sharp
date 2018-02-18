using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NETProject01
{
    public class NotaEntrada
    {
        public long? Id { get; set; }
        public string Numero { get; set; }
        public Fornecedor FornecedorNota { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }
        public IList<ProdutoNotaEntrada> Produtos { get; set; }

        public NotaEntrada()
        {
            this.Id = null;
            this.Produtos = new List<ProdutoNotaEntrada>();            
        }

        public NotaEntrada(long id)
        {
            this.Id = id;
        }

        public void RegistrarProduto(ProdutoNotaEntrada produto)
        {
            if (this.Produtos.Contains(produto))
                this.Produtos.Remove(produto);
            this.Produtos.Add(produto);
        }

        public void RemoverProduto(ProdutoNotaEntrada produto)
        {
            this.Produtos.Remove(produto);
        }

        public void RemoverTodosProdutos()
        {
            this.Produtos.Clear();
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
