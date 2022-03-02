using PruebaTecnica.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Core.Interfaces
{
   public interface IClientes
    {
        public IQueryable<Cliente> GetAll { get; }
        public Cliente GetById(int clienteId);
        public void Save (Cliente model);


    }
}
