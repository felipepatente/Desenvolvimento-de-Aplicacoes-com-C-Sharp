using ModelProject;
using PersistenceProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class ProdutoController
    {
        private Repository repository = new Repository();

        public Produto Insert(Produto produto)
        {
            return this.repository.InsertProduto(produto);
        }

        public void Remove(int index)
        {
            this.repository.RemoveProduto(index);
        }        

        public IList<Produto> GetAll()
        {
            return this.repository.GetAllProdutos();
        }

        public Produto Update(Produto produto)
        {
            return this.repository.UpdateProduto(produto);
        }
    }
}
