using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenceProject;
using ModelProject;

namespace ControllerProject
{
    public class FornecedorController
    {
        private Repository repository = new Repository();
        
        public Fornecedor Insert(Fornecedor fornecedor)
        {
            return this.repository.InsertFornecedor(fornecedor);
        }

        public void Remove(int index)
        {
            this.repository.RemoveFornecedor(index);
        }

        public IList<Fornecedor> GetAll()
        {
            return this.repository.GetAllFornecedores();
        }
        
        public Fornecedor Update(Fornecedor fornecedor)
        {            
            return this.repository.UpdateFornecedor(fornecedor);
        }        
    }
}
