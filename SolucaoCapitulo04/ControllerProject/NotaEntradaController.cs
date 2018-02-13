using ModelProject;
using PersistenceProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class NotaEntradaController
    {
        private Repository repository = new Repository();

        public NotaEntrada Insert(NotaEntrada notaEntrada)
        {
            return this.repository.InsertNotaEntrada(notaEntrada);
        }

        public void Remove(NotaEntrada notaEntrada)
        {
            this.repository.RemoveNotaEntrada(notaEntrada);
        }

        public IList<NotaEntrada> GetAll()
        {
            return this.repository.GetAllNotasEntrada();
        }

        public NotaEntrada Update(NotaEntrada notaEntrada)
        {
            return this.repository.UpdateNotaEntrada(notaEntrada);
        }

        public NotaEntrada GetNotaEntradaById(Guid Id)
        {
            return this.repository.GetNotaEntradaById(Id);
        }
    }
}
