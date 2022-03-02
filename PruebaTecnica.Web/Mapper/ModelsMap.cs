using AutoMapper;
using PruebaTecnica.Core.Models;
using PruebaTecnica.Web.Areas.Clientes.Models;
using PruebaTecnica.Web.Areas.Direcciones.Models;

namespace PruebaTecnica.Web.Mapper
{
    public class ModelsMap : Profile
    {
        public ModelsMap()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<DireccionesViewModel, Direcciones>();
            CreateMap<Direcciones, DireccionesViewModel>();
        }
    }
}
