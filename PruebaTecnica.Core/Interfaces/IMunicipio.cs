using PruebaTecnica.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Core.Interfaces
{
    public interface IMunicipio
    {
        public IQueryable<Municipio> GetAll{ get; }
    }
}
