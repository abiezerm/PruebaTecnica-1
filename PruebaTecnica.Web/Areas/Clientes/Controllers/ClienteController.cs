using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Core.Interfaces;
using PruebaTecnica.Core.Models;
using PruebaTecnica.Web.Areas.Clientes.Models;
using System;

namespace PruebaTecnica.Web.Area.Clientes.Controllers
{
    [Area("Clientes")]
    public class ClienteController : Controller
    {

        private readonly IClientes _clientes;
        private readonly IMapper _mapper;

        public ClienteController(IClientes clientes, IMapper mapper)
        {
            _clientes = clientes;
            _mapper = mapper;
        }

        public IActionResult Index() => View(_clientes.GetAll);

        public IActionResult AddCliente() => View();
        public IActionResult AddClientePost(ClienteViewModel model)
        {
            var map = _mapper.Map<Cliente>(model);

            if (ModelState.IsValid)
            {
                try
                {
                    _clientes.Save(map);

                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
            }
            else
            {
                return View("AddCliente", model);
            }

            return RedirectToAction("Index");
        }

        public IActionResult EditCliente(int clienteId) => View(_mapper.Map<ClienteViewModel>(_clientes.GetById(clienteId)));


        public IActionResult EditClientePost(ClienteViewModel model)
        {

            var map = _mapper.Map<Cliente>(model);


            if (ModelState.IsValid)
            {
                try
                {
                    _clientes.Save(map);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                return View("EditCliente", model);
            }


            return RedirectToAction("Index");
        }
    }
}
