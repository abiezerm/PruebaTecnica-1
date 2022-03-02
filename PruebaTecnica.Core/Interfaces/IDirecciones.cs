using PruebaTecnica.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Core.Interfaces
{
   public interface IDirecciones
    {
        public IQueryable<Direcciones> GetAll { get; }
        public Direcciones GetById(int direccionId);
        public void Save(Direcciones model);
        public void Remove(Direcciones model);
    }
}
