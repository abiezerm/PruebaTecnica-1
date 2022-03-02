using Microsoft.EntityFrameworkCore;
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
   public class DireccionesRepository : IDirecciones
    {
        private readonly PruebaDbContext _context;
        public DireccionesRepository(PruebaDbContext context)
        {
            _context = context;
        }
        public IQueryable<Direcciones> GetAll => _context.Direcciones
            .Include(x => x.Cliente)
            .Include(x => x.Provincia)
            .Include(x => x.Municipio);

        public Direcciones GetById(int direccionId) => GetAll.FirstOrDefault(x => x.DireccionId == direccionId);

        public void Remove(Direcciones model)
        {
            _context.Remove(model);

            _context.SaveChanges();
        }

        public void Save(Direcciones model)
        {
            var now = DateTime.Now;

            if (model.ClienteId != 0)
            {
                //model.FechaModificacion = now;
                _context.Update(model);
            }
            else
            {
                //model.FechaCreacion = now;
                _context.Add(model);
            }

            _context.SaveChanges();
        }

       
    }
}
