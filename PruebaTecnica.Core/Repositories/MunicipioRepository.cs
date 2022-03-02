using PruebaTecnica.Core.Context;
using PruebaTecnica.Core.Interfaces;
using PruebaTecnica.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Core.Repositories
{
    public class MunicipioRepository : IMunicipio
    {
        private readonly PruebaDbContext _context;
        public MunicipioRepository(PruebaDbContext context)
        {
            _context = context;
        }
        public IQueryable<Municipio> GetAll => _context.Municipios;
    }
}
