using PruebaTecnica.Core.Interfaces;
using PruebaTecnica.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Core.Context;
using Microsoft.EntityFrameworkCore;

namespace PruebaTecnica.Core.Repositories
{
    public class ClienteRepository : IClientes
    {
        private readonly PruebaDbContext _context;
        public ClienteRepository(PruebaDbContext context)
        {
            _context = context;
        }
        public IQueryable<Cliente> GetAll => _context.Clientes
            .Include(x => x.Direcciones)
            .ThenInclude(x => x.Provincia)
            .ThenInclude(x => x.Municipios);

        public Cliente GetById(int clienteId) => GetAll.FirstOrDefault(x => x.ClienteId == clienteId);

        public void Save(Cliente model)
        {
            var now = DateTime.Now;

            if(model.ClienteId != 0)
            {
                model.FechaModificacion = now;
                _context.Update(model);
            }
            else
            {
                model.FechaCreacion = now;
                _context.Add(model);
            }

            _context.SaveChanges();
        }
    }
}
