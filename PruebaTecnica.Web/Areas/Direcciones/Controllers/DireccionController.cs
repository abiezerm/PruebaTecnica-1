using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Core.Interfaces;
using PruebaTecnica.Web.Areas.Direcciones.Models;
using System;

namespace PruebaTecnica.Web.Areas.Direcciones.Controllers
{
    [Area("Direcciones")]
    public class DireccionController : Controller
    {
        private readonly IDirecciones _direcciones;
        private readonly IClientes _clientes;
        private readonly IMapper _mapper;
        public DireccionController(IDirecciones direcciones, IMapper mapper, IClientes clientes)
        {
            _direcciones = direcciones;
            _mapper = mapper;
            _clientes = clientes;
        }

        public IActionResult Index() => View(_direcciones.GetAll);

        public IActionResult AddDireccion(int clienteId)
        {
            var model = new DireccionesViewModel();
            model.ClienteId = clienteId;
            model.Cliente = _clientes.GetById(clienteId);

            return View(model);
        }

        public IActionResult AddDireccionPost(DireccionesViewModel model)
        {
            var map = _mapper.Map<PruebaTecnica.Core.Models.Direcciones>(model);


            if (ModelState.IsValid)
            {
                try
                {
                    _direcciones.Save(map);

                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
            }
            else
            {

                return View("AddDireccion", model);
            }

            return RedirectToAction("Index");
        }

        public IActionResult EditDireccion(int direccionId) => View(_mapper.Map<DireccionesViewModel>(_direcciones.GetById(direccionId)));

        public IActionResult EditDireccionPost(DireccionesViewModel model)
        {
            var map = _mapper.Map<PruebaTecnica.Core.Models.Direcciones>(model);


            if (ModelState.IsValid)
            {
                try
                {
                    _direcciones.Save(map);

                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
            }
            else
            {

                return View("EditDireccion", model);
            }

            return RedirectToAction("Index");
        }

        public IActionResult RemoveDireccion(int direccionId)
        {
            try
            {
                _direcciones.Remove(_direcciones.GetById(direccionId));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

           return RedirectToAction("Index");
        }
    }
}
